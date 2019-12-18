using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float minXLimit = -4.41f;
    public Image FruitsBar;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 4.25f)
            {
                FruitsBar.fillAmount -= 0.02f;
                if (FruitsBar.fillAmount == 0)
                {
                    UiManagerGame.instance.GameOver();
                }

                transform.Translate(Vector2.right + new Vector2(0.25f, 0f));

            }
            else if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -4.5f)
            {
                FruitsBar.fillAmount -= 0.02f;
                if (FruitsBar.fillAmount == 0)
                {
                    UiManagerGame.instance.GameOver();
                }
                transform.Translate(Vector2.left - new Vector2(0.25f, 0f));

            }
            else if (Input.GetKeyDown(KeyCode.S) && transform.position.y != -4.3f)
            {
                FruitsBar.fillAmount -= 0.02f;
                if (FruitsBar.fillAmount == 0)
                {
                    UiManagerGame.instance.GameOver();
                }
                transform.Translate(Vector2.down - new Vector2(0f, 0.25f));

            }
            else if (Input.GetKeyDown(KeyCode.W) && transform.position.y != 4.45f)
            {
                FruitsBar.fillAmount -= 0.02f;
                if (FruitsBar.fillAmount == 0)
                {
                    UiManagerGame.instance.GameOver();
                }
                transform.Translate(Vector2.up + new Vector2(0f, 0.25f));

            }
        }

      
        // if (Input.GetKey(KeyCode.RightArrow))
        // if (Input.GetKey(KeyCode.UpArrow))
        // if (Input.GetKey(KeyCode.DownArrow))


    }

    public void MoveRight()
    {
        transform.Translate(transform.position.x - 0.001f, 0.0f, 0.0f);
    }

}