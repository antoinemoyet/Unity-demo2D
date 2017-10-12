using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D body;

	private float xInput;
	private float yInput; 

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		yInput = Input.GetAxis("Vertical");
		xInput = Input.GetAxis("Horizontal");
	}
}