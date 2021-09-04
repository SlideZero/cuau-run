using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMasterEvents : MonoBehaviour {

	public GameObject[] _enemies;
	public float _spawnTime = 3f;
	public Transform[] _spawnPoints;
	public GameObject _imageTarget;

	//Variables de pausa o "DeadState"
	public static bool _isPause;
	public GameObject _panelMenu;
	public bool _muerto = false;
	public bool _pausa = false;

	/*************************EXPERIMENTAL DEADSTAND**********************************/
	public bool _iTronco = false;
	public bool _iMuro = false;
	public bool _iJarron = false;

	public GameObject _imgTronco;
	public GameObject _imgJarron;
	public GameObject _imgMuro;
	/*********************************************************************************/

	// Use this for initialization
	void Start () {
		_isPause = false;
		_panelMenu.SetActive (false);
		_imgJarron.SetActive (false);
		_imgTronco.SetActive (false);
		_imgMuro.SetActive (false);
		InvokeRepeating ("SpawnEnemy", _spawnTime, _spawnTime);
	}

	void Update()
	{
		GamePause ();
	}
		
	public void GamePause()
	{
		if (_muerto && !_pausa) 
		{
			_isPause = !_isPause;
			_panelMenu.SetActive (_isPause);
			Time.timeScale = _isPause ? 0 : 1;
			_pausa = true;

			/********EXPERIMENTAL DEADSTAND***********/
			if(_iJarron)
			{
				_imgJarron.SetActive (true);
			}
			else if(_iTronco)
			{
				_imgTronco.SetActive (true);
			}
			else if(_iMuro)
			{
				_imgMuro.SetActive (true);
			}
			/*****************************************/
		}
	}

	public void SiguienteEscena(string _nombreEscena)
	{
		SceneManager.LoadScene(_nombreEscena);
		Time.timeScale = 1;
	}

	void SpawnEnemy()
	{
		int EnemyIndex = Random.Range (0, _enemies.Length);
		int SpawnPointIndex = Random.Range (0, _spawnPoints.Length);

		GameObject _obstaculo = Instantiate (_enemies[EnemyIndex], _spawnPoints[SpawnPointIndex].position, _spawnPoints[SpawnPointIndex].rotation);
		_obstaculo.transform.parent = _imageTarget.transform;
	}

}
