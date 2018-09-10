/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour {

	public void RestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
	}

}