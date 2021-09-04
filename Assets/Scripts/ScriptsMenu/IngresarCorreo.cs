using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresarCorreo : MonoBehaviour {

	string inputCorreo;
	public InputField mainInputField;

	public void GuardarDato()
	{
		inputCorreo = mainInputField.text;
		Debug.Log("Correo: " + inputCorreo);
	}

	public string getInputCorreo() {
		return inputCorreo;
	}
}
