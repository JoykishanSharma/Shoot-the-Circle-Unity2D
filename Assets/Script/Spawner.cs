﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pinPrefab;
	
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
		{
			SpawnPin();
		}
    }
	
	void SpawnPin()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}
}
