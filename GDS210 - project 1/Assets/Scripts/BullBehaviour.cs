using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullBehaviour : MonoBehaviour
{
    public Transform target;
    public float bullChargespeed = 10;
    public float bullRange; 
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, target.position) < bullRange)
            transform.position = Vector3.MoveTowards(transform.position, target.position, (bullChargespeed * Time.deltaTime));
    }
}
