using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuggyMovement : MonoBehaviour
{
    public float buggyBaseSpeed;
    public float buggyCurrSpeed;
    public float buggyPercIncSpeed; 

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        BuggyControl();

        transform.Translate((Vector2.right * buggyCurrSpeed) * Time.deltaTime);
	}

    void BuggyControl ()
    {
        if (Input.GetKeyDown (KeyCode.LeftArrow))
            buggyCurrSpeed -= (buggyBaseSpeed * buggyPercIncSpeed) * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            buggyCurrSpeed += (buggyBaseSpeed * buggyPercIncSpeed) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.RightArrow))
            buggyCurrSpeed -= (buggyBaseSpeed * buggyPercIncSpeed) * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.RightArrow))
            buggyCurrSpeed += (buggyBaseSpeed * buggyPercIncSpeed) * Time.deltaTime;
    }
}
