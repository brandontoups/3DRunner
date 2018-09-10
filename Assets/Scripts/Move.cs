/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	
	public float speed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponentInChildren<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		rb = GetComponentInChildren<Rigidbody> ();
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = 10;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}
}
