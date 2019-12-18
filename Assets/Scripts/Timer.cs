using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(timerCOuntDown());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator timerCOuntDown()
    {
        yield return new WaitForSeconds(0.1f);

        gameObject.GetComponent<Image>().fillAmount = gameObject.GetComponent<Image>().fillAmount - 0.001f;

        if (gameObject.GetComponent<Image>().fillAmount == 0)
        {
            UiManagerGame.instance.TimeUpPanel();
        }

        StartCoroutine(timerCOuntDown());
    }
}
