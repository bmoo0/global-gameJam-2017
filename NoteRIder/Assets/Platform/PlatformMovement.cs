using UnityEngine;
using System.Collections.Generic;

public class PlatformMovement: MonoBehaviour {
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    void Start() {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update() {
        double y = 0;
        y = 1.5;
        y = 3;
        y = 4.5;

        if (transform.position.x >= generationPoint.position.x - platformWidth)
        {
           transform.position = new Vector2(transform.position.x + platformWidth + distanceBetween, transform.position.y);
           Instantiate(thePlatform, transform.position, transform.rotation);
        }
    }
}