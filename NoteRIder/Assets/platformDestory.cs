using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestory : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {

        Destroy(platform);
        Debug.Log("Platform destroyed!");
    }
}
