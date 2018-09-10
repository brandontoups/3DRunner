/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeShape : MonoBehaviour {

	public GameObject tallPlayer;
	public GameObject widePlayer;
	public string playerChoice;


	// Use this for initialization
	void Start () {
		tallPlayer.SetActive (true);
		widePlayer.SetActive (false);
		playerChoice = "wide";
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && playerChoice == "wide") {
			
			tallPlayer.SetActive (false);
			widePlayer.SetActive (true);
			playerChoice = "tall";

		} else if (Input.GetKeyDown ("space") && playerChoice == "tall") {

			tallPlayer.SetActive (true);
			widePlayer.SetActive (false);
			playerChoice = "wide";

		}



	
	}
}
