using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killZone : MonoBehaviour {

    private Rigidbody2D body;
    public float right;

    //Transform ball;

    // Use this for initialization
    void Start () {
		//ball = GameObject.Find("Circle").transform;
	}
	
	// Update is called once per frame
	void Update () {
        
            Vector2 rVec = new Vector2(right, 0f);
            body.AddForce(rVec * 10);
        //transform.position = new Vector3 (ball.position.x, transform.position.y, transform.position.z);
    }

	void OnTriggerEnter2D(Collider2D col) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
