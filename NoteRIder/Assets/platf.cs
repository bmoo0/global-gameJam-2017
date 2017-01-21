
using UnityEngine;

public class platf : MonoBehaviour {
    private Rigidbody2D body;
    public float moveRight;
	// Use this for initialization
	void Start () {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 vec = new Vector2(moveRight, 0f);
        body.AddForce(vec * 10);
    }
}
