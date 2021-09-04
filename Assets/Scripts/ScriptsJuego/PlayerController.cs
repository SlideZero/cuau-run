using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



	//Player Controller Movements
	/****************************************************/
	public GameObject Player;

	private float limInfLeft = -3.5f;
	private float limSupLeft = -1.2f;
	private float limInfCenter = -1.2f;
	private float limSupCenter = 1.2f;
	private float limInfRigth = 1.2f;
	private float limSupRigth = 3.5f;

	private float lineLeft = -2.3f;
	private float lineCenter = 0;
	private float lineRigth = 2.3f;

	private Vector3 startMarker;
	private Vector3 endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	private float factor;
	private bool finish;


	public void MoveLeft()
	{
		if (Player.transform.position.x > limInfCenter && Player.transform.position.x < limSupCenter) 
		{
			StartCoroutine (MoveLeftAction ());
		}
		else if (Player.transform.position.x > limSupCenter) 
		{
			StartCoroutine (MoveCenterAction ());
		}
	}

	public void MoveRigth()
	{
		if (Player.transform.position.x > limInfCenter && Player.transform.position.x < limSupCenter) 
		{
			StartCoroutine (MoveRigthAction ());
		}
		else if (Player.transform.position.x < limInfCenter) 
		{
			StartCoroutine (MoveCenterAction ());
		}
	}

	IEnumerator MoveLeftAction()
	{
		startMarker = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
		endMarker = new Vector3 (lineLeft, Player.transform.position.y, Player.transform.position.z);

		float startTime = Time.time; //start time.
		finish = false;

		while (!finish) {
			factor = ((Time.time - startTime)) / 0.3f;
			Player.transform.position = Vector3.Lerp (startMarker, endMarker, factor);
			finish = factor >= 1 ? true : false;
			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator MoveRigthAction()
	{
		startMarker = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
		endMarker = new Vector3 (lineRigth, Player.transform.position.y, Player.transform.position.z);

		float startTime = Time.time; //start time.
		finish = false;

		while (!finish) {
			factor = ((Time.time - startTime)) / 0.3f;
			Player.transform.position = Vector3.Lerp (startMarker, endMarker, factor);
			finish = factor >= 1 ? true : false;
			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator MoveCenterAction()
	{
		startMarker = new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
		endMarker = new Vector3 (lineCenter, Player.transform.position.y, Player.transform.position.z);

		float startTime = Time.time; //start time.
		finish = false;

		while (!finish) {
			factor = ((Time.time - startTime)) / 0.3f;
			Player.transform.position = Vector3.Lerp (startMarker, endMarker, factor);
			finish = factor >= 1 ? true : false;
			yield return new WaitForEndOfFrame();
		}
	}
}