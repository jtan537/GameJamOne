﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
    	offset = new Vector3(0, 1, -5);
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position = player.position + offset;
        
    }
}