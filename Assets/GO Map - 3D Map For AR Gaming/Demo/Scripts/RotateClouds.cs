﻿using UnityEngine;
using System.Collections;

public class RotateClouds : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.Rotate(0,speed*Time.deltaTime,0);
	}
}
