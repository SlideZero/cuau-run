using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour {

	private float _velocidad = 0;
	public static Renderer _render;

	// Use this for initialization
	void Start () {
		_render = gameObject.GetComponent<Renderer>();
	}

	void Update()
	{
		_velocidad += 0.5f * Time.deltaTime;
		/*_posicion += _velocidad;
		if (_posicion > 1.0f) {
			_posicion -= 1.0f;
		}*/
		//_render.material.mainTextureOffset = new Vector2 (_posicion, 0);
		_render.material.mainTextureOffset = new Vector2 (_velocidad, 0);
	}
}
