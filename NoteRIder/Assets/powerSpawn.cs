using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerSpawn : MonoBehaviour {

    public GameObject sharp;
    public GameObject rest;
    public Transform powerPoint;

    private float powerWidth;
    private float powerUp;
    private int c = 0;

    // Use this for initialization
    void Start () {
        powerWidth = sharp.GetComponent<BoxCollider2D>().size.x;
        powerUp = Random.Range(1, 110);
    }
	
	// Update is called once per frame
	void Update () {
        if (powerUp >= 100 && c == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            Instantiate(sharp, transform.position, transform.rotation);
            c++;      
        }
        else if (powerUp <= 10 && c == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            Instantiate(rest, transform.position, transform.rotation);
            c++;
        }

    }

}
