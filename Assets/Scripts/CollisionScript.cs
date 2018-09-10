/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour {
	public GameObject deathParticles;

    private bool isDead = false;
	public AudioSource deathAudio;
	public AudioClip deathSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -3) {
			die ();
		}

		
	}
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag ("Gate")) {
			die ();
		}


	}

	void die() {
		deathAudio.PlayOneShot(deathSound, 1f);
        isDead = true;
		Debug.Log ("Dead", gameObject);
        Destroy(gameObject);
        FindObjectOfType<GameOver>().EndGame();
		Instantiate (deathParticles, transform.position, Quaternion.identity);
	}
}
