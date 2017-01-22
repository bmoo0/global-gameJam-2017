using UnityEngine;


public class Power : MonoBehaviour {
    public GameObject power;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(power);
    }
}
