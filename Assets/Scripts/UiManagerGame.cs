using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManagerGame : MonoBehaviour {

    public static UiManagerGame instance;

    public GameObject gameOverPanel,gameCompletePanel,timeUpPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void YesButton()
    {
        Application.LoadLevel("GameLevel");
    }

    public void NoButton()
    {
        Application.LoadLevel("MainMenu");
    }

    public void GameOver()
    {
        GameManager.instance.isGameOver = true;
        gameOverPanel.SetActive(true);
    }
    
    public void GameComplete()
    {
        GameManager.instance.isGameOver = true;
        gameCompletePanel.SetActive(true);
    }

    public void TimeUpPanel()
    {
        GameManager.instance.isGameOver = true;
        timeUpPanel.SetActive(true);

    }
}
