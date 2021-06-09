using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Treasure : MonoBehaviour
{
    public GameObject gameManager;

    private void OnMouseDown()
    {
        if (gameObject.tag == "Trophy")
            gameManager.GetComponent<GameManager>().isTrophyCollected = true;

        if (gameObject.tag == "Stapler")
            gameManager.GetComponent<GameManager>().isStaplerCollected = true;

        Destroy(gameObject);
    }

    private void Update()
    {
        /*
        if (gameManager.GetComponent<GameManager>().isTrophyCollected)
        {
            if (gameObject.tag == "Trophy")
                gameObject.SetActive(false);
        }
        */

        if (gameManager.GetComponent<GameManager>().isStaplerCollected)
        {
            if (gameObject.tag == "Stapler")
                gameObject.SetActive(false);
        }
    }

}
