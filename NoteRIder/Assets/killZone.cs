using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killZone : MonoBehaviour {

	Transform ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("Circle").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (ball.position.x, transform.position.y, transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D col) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
