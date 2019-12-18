using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour {

    public GameObject mainScreenPanel;
    public GameObject mainMenuPanel, howToPlayPanel, exitPanel, aboutPanel, optionsPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartButton()
    {
        mainScreenPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    public void PlayButton()
    {
        Application.LoadLevel("GameLevel");
    }

    public void HowtoPlay()
    {
        mainMenuPanel.SetActive(false);
        howToPlayPanel.SetActive(true);
    }

    public void BackButton()
    {
        howToPlayPanel.SetActive(false);
        aboutPanel.SetActive(false);
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void OptionsButton()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void AboutButton()
    {
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void ExitButton()
    {
        mainMenuPanel.SetActive(false);
        exitPanel.SetActive(true);
    }
    
    public void YesButton()
    {

        Application.Quit();
    }

    public void NoButton()
    {
        exitPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
