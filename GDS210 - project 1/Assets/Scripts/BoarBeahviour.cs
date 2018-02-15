using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarBeahviour : MonoBehaviour
{
    public Transform target;
    public float boarChargespeed = 15;
    public int boarRange = 10;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, target.position) < boarRange)
            transform.position = Vector3.MoveTowards(transform.position, target.position, (boarChargespeed * Time.deltaTime));

    }
}
