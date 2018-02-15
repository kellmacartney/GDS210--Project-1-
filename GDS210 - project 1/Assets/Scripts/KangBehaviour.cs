using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangBehaviour : MonoBehaviour
{
    public Transform target;
    public float kangChargespeed;
    public float kangRange; 


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, target.position) < kangRange)
            transform.position = Vector3.MoveTowards(transform.position, target.position, (kangChargespeed * Time.deltaTime));
    }
}
