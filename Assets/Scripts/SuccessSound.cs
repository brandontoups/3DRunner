/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSound : MonoBehaviour {
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter( Collider other )
	{

		if( other.gameObject.tag == "successCube" )
		{
			AudioSource.PlayClipAtPoint(clip, transform.position); 
		}

	}
}
