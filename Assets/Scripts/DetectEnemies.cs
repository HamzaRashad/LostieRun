﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemies : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		


        if (collision.gameObject.tag == "Enemy")
        {
			GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            SoundManager.playSound("gameoverSFX");
            print("enemy");
            UiManagerGame.instance.GameOver();
        }
    }
}
