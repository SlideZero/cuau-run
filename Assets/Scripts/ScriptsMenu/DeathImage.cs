using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DeathImage : MonoBehaviour {

	public Sprite roca;
	public Sprite jarron;
	public Sprite fuego;
	public Sprite tronco;
	public Sprite pared;

	int tipoDeMuerte = 0;

	void Start() {
		tipoDeMuerte = (int) Random.Range (1.0f, 5.0f);
		Debug.Log ("Random: " + tipoDeMuerte);
	
		Invoke ("SetSprite", 1f);
	}

	void SetSprite() {
		if (tipoDeMuerte == 1) {	//roca
			GetComponent<Image> ().sprite = roca;
		} else if (tipoDeMuerte == 2) {	//fuego
			GetComponent<Image> ().sprite = fuego;
		} else if (tipoDeMuerte == 3) {	//jarron
			GetComponent<Image> ().sprite = jarron;
		} else if (tipoDeMuerte == 4) {	//tronco
			GetComponent<Image> ().sprite = tronco;
		} else if (tipoDeMuerte == 5) { //pared
			GetComponent<Image> ().sprite = pared;
		}

	}
}
