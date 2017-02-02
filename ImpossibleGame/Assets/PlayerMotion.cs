//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Used for text in HUD Canvas

public class PlayerMotion : MonoBehaviour {

	//Attributes
	// - public attributes - visible in the editor
	private float xVelocity = 15f,
				  yVelocity = 15f;
	private AudioSource enemy;
	public int lives = 3,
				points = 0;
	public Text Score;
	public Text Lives;

	// Use this for initialization

	void Start () {
		setLivesText ();
		setScoreText ();
		enemy = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		//Move with left joystick or arrow keys
		transform.Translate (
			xVelocity * h * Time.deltaTime,
			0,
			yVelocity * v * Time.deltaTime
		);
	}

	void OnCollisionEnter(Collision c){
		//If collisioning against an enemy, return to initial position, lives--
		if (c.gameObject.layer == 9) {
			enemy.Play (); //Sound FX
			this.transform.position = new Vector3 (0,0,0);
			lives = lives - 1;
			setLivesText ();
		}
		//If collisioning against green wall or goal, return to initial pos, points++
		else if (c.gameObject.layer == 10){
			this.transform.position = new Vector3 (0,0,0);
			points = points + 1;
			setScoreText ();
		}

	}
	//Avoiding code re-write
	void setScoreText(){
		Score.text = "Score: " + points.ToString ();
	}
	//Avoiding code re-write
	void setLivesText(){
		Lives.text = "Lives: " + lives.ToString ();
	}
}
