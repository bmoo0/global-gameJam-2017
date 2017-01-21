using UnityEngine;
using System.Collections.Generic;

public class PlatformMovement: MonoBehaviour {
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public Transform farEnd;
    private Vector3 frometh;
    private Vector3 untoeth;
    private float secondsForOneLength = 20f;

    private float platformWidth;

    void Start() {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        frometh = transform.position;
        untoeth = farEnd.position;
    }

    void Update() {
        
         if (transform.position.x >= generationPoint.position.x - platformWidth)
        {
            while (true)
            {
                transform.position = new Vector2(transform.position.x + platformWidth + distanceBetween, transform.position.y);
                Instantiate(thePlatform, transform.position, transform.rotation);
            }
        }
        transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));
    }
}