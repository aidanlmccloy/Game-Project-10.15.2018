﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishing_Line : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
    {
		if (other.gameObject.CompareTag("Finishing Line"))
        {
            other.gameObject.SetActive(false);
        }
	}
}
