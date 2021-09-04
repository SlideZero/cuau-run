using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigos : MonoBehaviour {

	public float _velocidad = 3f;
	public GameObject _gameMasterEvents;
	public GameMasterEvents _gameMasterScript;

	void Start()
	{
		_gameMasterEvents = GameObject.Find("GameMasterEvents");
		_gameMasterScript = _gameMasterEvents.GetComponent<GameMasterEvents> ();	
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.back  * Time.deltaTime * _velocidad);

		if (transform.position.z < -2f)
			Destroy (gameObject);
	}

	void OnTriggerEnter(Collider collider)
	{
		//_gameMasterScript._muerto = true;

		if(gameObject.tag == "Tronco")
		{
			_gameMasterScript._iTronco = true;
		}
		else if(gameObject.tag == "Muro")
		{
			_gameMasterScript._iMuro = true;
		}
		else if(gameObject.tag == "Jarron")
		{
			_gameMasterScript._iJarron = true;
		}
		_gameMasterScript._muerto = true;
	}

}
