//												Author: Michelle Sagnelli
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSound : MonoBehaviour {

	//Importing component to code for playing on collision Sound FX
	private AudioSource point;

	// Use this for initialization
	void Start () {
		point = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		point.Play ();
	}
}
