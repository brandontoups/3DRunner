/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EasyMode : MonoBehaviour {

	private CharacterController controller;
	private float speed = 5.0f;
	private Vector3 moveVector;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;
	private float animationDuration = 0.5f;
	private bool isDead = false;
	private Vector3 spawn;
	//private Rigidbody rb;



	void Start () {

		spawn = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		//rb = GetComponentInChildren<Rigidbody> ();
		controller = GetComponent<CharacterController> ();
		if (transform.position.y < -5) {
			isDead = true;
			die ();
		}
		if (isDead) {
			return;
		}
		if (Time.time < animationDuration) {
			//transform.Translate (Vector3.forward * speed * Time.deltaTime);
			controller.Move (Vector3.forward * speed * Time.deltaTime);
			return;
		}
		moveVector = Vector3.zero;

		//if (controller.isGrounded) {
			//verticalVelocity = -0.5f;

		//} 
		//else {
			//verticalVelocity -= gravity * Time.deltaTime;

		//}
		moveVector.x = Input.GetAxisRaw ("Horizontal") * speed  * Time.deltaTime;
		moveVector.y = 0f;
		moveVector.z = speed  * Time.deltaTime;
		controller.Move (moveVector);
		//rb.AddForce(moveVector);
	}
	public void setSpeed(float modifier) {
		speed = 7.0f  + modifier;
	}

	/*void OnControllerColliderHit(ControllerColliderHit hit) {
		if(!hit.gameObject.CompareTag("Ground")){
		die ();
		}
	}*/
	void OnCollisionEnter(Collision other) {

		if (!other.gameObject.CompareTag ("Ground")) {
			
			die ();
		}
	}

	void die() {
		
		isDead = true;
        Destroy(gameObject);
        FindObjectOfType<GameOver>().EndGame();
		//Instantiate (deathParticles, transform.position, Quaternion.identity);
    }
}
