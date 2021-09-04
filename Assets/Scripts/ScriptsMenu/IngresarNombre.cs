using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresarNombre : MonoBehaviour {

	string inputNombre;
	public InputField mainInputField;

	public void GuardarDato()
	{
		inputNombre = mainInputField.text;
		Debug.Log("Input: " + inputNombre);
	}

	public string getInputNombre() {
		return inputNombre;
	}
}
