using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    public static AudioClip gameOverSFX, pickupSFX;
    static AudioSource audioSrc;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {

        gameOverSFX = Resources.Load<AudioClip>("gameoverSFX");
        pickupSFX = Resources.Load<AudioClip>("pickup");

        audioSrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void playSound(string clip)
    {
        switch (clip)
        {
            case "gameoverSFX":
                audioSrc.PlayOneShot(gameOverSFX);
                break;
            case "pickup":
                audioSrc.PlayOneShot(pickupSFX);
                break;
        }
    }
}
