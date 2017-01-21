using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
	private Rigidbody2D body;
	public float speed;
	private Vector2 current;
	private float curX;
	double mapX = 100.0;
	double mapY = 100.0;
	double camSize;
	double horizExtent;
	double minX;
	double maxX;
	double minY;
	double maxY;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D> ();
		camSize = Camera.main.orthographicSize;
		horizExtent = camSize * Screen.width / Screen.height;
		minX = horizExtent - mapX / 2.0;
		maxX = mapX / 2.0 - horizExtent;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vec = new Vector2 (speed, 0f);
		body.AddForce (vec * 10);
		if (transform.position.x < minX) {
			//transform.position.x = maxX;
		}
	}
}
