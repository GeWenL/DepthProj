using UnityEngine;
using System.Collections;

public class SetColor : MonoBehaviour {
	public Color color;
	// Use this for initialization
	void Start () {
		Renderer render = gameObject.GetComponent<Renderer>();

		render.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
