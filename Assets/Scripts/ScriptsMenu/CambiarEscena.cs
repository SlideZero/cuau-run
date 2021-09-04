using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiarEscena : MonoBehaviour {

	void Awake()
	{
		Screen.orientation = ScreenOrientation.Landscape;
	}

	public void SiguienteEscena(string _nombreEscena)
    {
        SceneManager.LoadScene(_nombreEscena);
		Debug.Log ("Cambio de Escena");
    }
}
