using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    float minXLimit = -4.34f;
    float maxXLimit = 4.41f;
    float minYLimit = -4.39f;
    float maxYLimit = 4.36f;

    public float delaySpeed;




    // Use this for initialization
    void Start () {

        StartCoroutine(MoveEnemy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator MoveEnemy()
    {
        yield return new WaitForSeconds(delaySpeed);

        if (!GameManager.instance.isGameOver)
        {
            int number = Random.Range(0, 4);

            if (number == 3 && transform.position.x != minXLimit) // for moving left
            {
                transform.Translate(Vector2.left - new Vector2(0.25f, 0f));
            }

            else if (number == 2 && transform.position.x != maxXLimit) // for moving right
            {
                transform.Translate(Vector2.right + new Vector2(0.25f, 0f));
            }

            else if (number == 1 && transform.position.y != maxYLimit) // for moving up
            {
                transform.Translate(Vector2.up + new Vector2(0f, 0.25f));
            }

            else if (number == 0 && transform.position.y != minYLimit) // for moving down
            {
                transform.Translate(Vector2.down - new Vector2(0f, 0.25f));
            }

            StartCoroutine(MoveEnemy());
        }

           
    }
}
