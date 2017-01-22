using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killZone : MonoBehaviour {

    private Rigidbody2D body;
    public float right;

    
    
    void Start () {
		
	}
	
	void Update () {
        
            Vector2 rVec = new Vector2(right, 0f);
            body.AddForce(rVec * 10);
        
    }

	void OnTriggerEnter2D(Collider2D col) {
		SceneManager.LoadScene ("DeathMenu");
	}
}
