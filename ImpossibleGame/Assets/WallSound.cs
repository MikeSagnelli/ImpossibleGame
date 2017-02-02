//												Author: Michelle Sagnelli
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSound : MonoBehaviour {

	private AudioSource crash;

	// Use this for initialization
	void Start () {
		crash = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		//Pure Sound FX
		crash.Play ();
	}
}
