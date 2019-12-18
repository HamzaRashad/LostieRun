using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DetectFruits : MonoBehaviour {

    public Image FruitsBar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Fruit")
        {
            SoundManager.playSound("pickup");
            collision.gameObject.SetActive(false);
            FruitsSpawner.instance.RespawnFruit(collision.gameObject);

            FruitsBar.fillAmount += 0.04f;
            if (FruitsBar.fillAmount == 1)
            {
               // UiManagerGame.instance.GameComplete();
            }
        }
    }
}
