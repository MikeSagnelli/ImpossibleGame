//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	//We are going to be controlling and using data from our main player
	public PlayerMotion playerMotion;
	//Time it will take for animation before closing
	public float restartDelay = 5f;

	Animator anim;
	float restartTimer;

	// Use this for initialization
	void Start () {

		//Initialize animator and playerMotion by seeking the tag Player
		anim = GetComponent<Animator> ();
		playerMotion = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMotion> ();
	}

	// Update is called once per frame
	void Update () {
		//If lost
		if (playerMotion.lives <= 0) {
			//Player GameObject becomes unusable
			Destroy (playerMotion);
			//Begin animation
			anim.SetTrigger ("GameOver");
			//Run until time's up
			restartTimer += Time.deltaTime;
			if (restartTimer >= restartDelay) {
				//Close game, only works in exe file
				Application.Quit ();
			}
		}
	}
}
