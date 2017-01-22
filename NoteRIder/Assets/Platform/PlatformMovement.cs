using UnityEngine;

public class PlatformMovement: MonoBehaviour {
    public GameObject thePlatform;
    public GameObject powerUp;
    public Transform generationPoint;
    public Transform powerPoint;

    private float platformWidth;


    void Start() {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
      
    }

    void Update() {
        float distanceBetween = Random.Range(7f, 15f);
        float powerUp = Random.Range(1, 100);

         if (transform.position.x < generationPoint.position.x)
        {
                       
                transform.position = new Vector2(transform.position.x + platformWidth + distanceBetween, transform.position.y);
                Instantiate(thePlatform, transform.position, transform.rotation);
                     
        }
      
    }
    
}