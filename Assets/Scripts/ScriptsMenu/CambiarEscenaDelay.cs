using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaDelay : MonoBehaviour {

	public string nombreEscena;

	void Start() {
		StartCoroutine ("SiguienteEscena");
	}

	public IEnumerator SiguienteEscena()
	{
		yield return new WaitForSeconds(1.3f);

		SceneManager.LoadScene (nombreEscena);
		Debug.Log ("Se cambio de escena");
	}


}
