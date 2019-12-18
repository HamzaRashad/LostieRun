using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsSpawner : MonoBehaviour {

    public static FruitsSpawner instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnFruit(GameObject fruit)
    {
        StartCoroutine(RespawnFruitE(fruit));
    }

    public IEnumerator RespawnFruitE(GameObject fruit)
    {
        yield return new WaitForSeconds(Random.Range(10, 15));

        fruit.SetActive(true);
    }
}
