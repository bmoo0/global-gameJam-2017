﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	private Rigidbody2D body;
	public float jump;
	public float right;
	private bool canJump = true;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D> ();

		
	}		

	
	// Update is called once per frame
	void FixedUpdate () {

		// once touched a platform allow player to jump again
		if (body.velocity.y == 0) {
			canJump = true;
		}

		if (Input.GetKeyDown (KeyCode.Space) && this.canJump == true) {
			Vector2 vec = new Vector2 (0f, jump);
			body.AddForce (vec * 10);
			canJump = false;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector2 rVec = new Vector2 (right, 0f);
			body.AddForce (rVec * 10);
		}
	}
}