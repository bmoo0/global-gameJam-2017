using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharpPower : MonoBehaviour
{

    public float sharp;

    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "player")
        {
            Destroy(node.gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
