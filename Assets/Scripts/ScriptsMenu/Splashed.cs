using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Splashed : MonoBehaviour {

	public GameObject otherGO;
	Animator otherAnimator;

	void Start () {
		otherGO = GameObject.Find("img_splashBackground");
		otherAnimator = otherGO.GetComponent<Animator>();
	}

	public void itSplashed () {
		otherAnimator.SetBool ("Splashed", true);
		Debug.Log ("It Splashed");
	}
}
