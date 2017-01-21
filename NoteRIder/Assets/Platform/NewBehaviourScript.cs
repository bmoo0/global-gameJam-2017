using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Transform moveplat;
    public Transform pos1;
    public Transform pos2;
    public Vector3 newPos;
    public string currState;     
    public float smooth;
    public float resetTime;


    void Start () {
        ChangeTarget();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        moveplat.position = Vector3.Lerp(moveplat.position, newPos, smooth*Time.deltaTime);

    }
    void ChangeTarget() {
        if (currState == "Moving to Position 1")
        {
            currState = "Moving to Position 2";
            newPos = pos2.position;
        }
        else if (currState == "Moving to Position 2")
        {
            currState = "Moving to Position 1";
            newPos = pos1.position;
        }
        else if (currState == "")
        {
            currState = "Moving to Position 2";
            newPos = pos2.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}
