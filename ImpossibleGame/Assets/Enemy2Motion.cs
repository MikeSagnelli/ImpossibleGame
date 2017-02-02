//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Motion : MonoBehaviour {

	//attributes
	private float xVelocity = 65f,
				  h = -0.75f;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		//Auto moving object
		transform.Translate (
			xVelocity * h * Time.deltaTime,
			0,
			0
		);

	}

	void OnCollisionEnter(Collision c){
		//When collisioning against a white wall, change direction
		if (c.gameObject.layer == 11) {
			h = -h;
		}
	}
}
