using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Transform trans = player.GetComponent<Transform> ();
		Vector3 vec = new Vector3 (trans.position.x, trans.position.y, -10f);
		gameObject.GetComponent<Transform> ().position = vec;
	}
}
