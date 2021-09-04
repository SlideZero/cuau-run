using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresarTelefono : MonoBehaviour {

	string inputTelefono;
	public InputField mainInputField;

	public void GuardarDato()
	{
		inputTelefono = mainInputField.text;
		Debug.Log("Telefono: " + inputTelefono);
	}

	public string getInputTelefono() {
		return inputTelefono;
	}
}
