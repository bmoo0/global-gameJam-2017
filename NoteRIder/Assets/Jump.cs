using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	private Rigidbody2D body;
    public AudioSource playerJump;
	public float jump;
	public float right;
	private bool canJump = true;
    public static float distanceTraveled;

    // Use this for initialization
    void Start () {
		body = gameObject.GetComponent<Rigidbody2D> ();

		
	}		

	
	// Update is called once per frame
	void FixedUpdate () {

        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        distanceTraveled = transform.localPosition.x;
        // once touched a platform allow player to jump again
        if (body.velocity.y == 0) {
			canJump = true;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && this.canJump == true) {
			Vector2 vec = new Vector2 (12f, jump);
			body.AddForce (vec * 10);
            playerJump.Play();
			canJump = false;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector2 rVec = new Vector2 (right, 0f);
			body.AddForce (rVec * 10);
		}
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 rVec = new Vector2(-right, 0f);
            body.AddForce(rVec * 10);
        }
    }
}
