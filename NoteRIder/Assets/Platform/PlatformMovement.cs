using UnityEngine;

public class PlatformMovement: MonoBehaviour {
    public GameObject thePlatform;
    public GameObject powerUp;
    public Transform generationPoint;
    private Rigidbody2D body;

    private float platformWidth;


    void Start() {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update() {
        float distanceBetween = Random.Range(7f, 15f);
        

         if (transform.position.x < generationPoint.position.x)
        {
                       
                transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
                Instantiate(thePlatform, transform.position, transform.rotation);
                body.AddForce(transform.position * 1);
        }
      
    }
    
}