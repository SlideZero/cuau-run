using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresarInfo : MonoBehaviour {

	string input;
	public InputField mainInputField;

	public void GuardarDato()
	{
		input = mainInputField.text;
		Debug.Log("Input: " + input);
	}
}
