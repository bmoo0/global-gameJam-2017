using UnityEngine;
using System.Collections.Generic;

public class PlatformMovement: MonoBehaviour {
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public double y;

    private float platformWidth;

    void Start() {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update() {
        
         if (transform.position.x >= generationPoint.position.x - platformWidth)
        {
            while (true)
            {
                y += 1.5;
                transform.position = new Vector2(transform.position.x + platformWidth + distanceBetween, transform.position.y);
                Instantiate(thePlatform, transform.position, transform.rotation);
            }
        }
    }
}