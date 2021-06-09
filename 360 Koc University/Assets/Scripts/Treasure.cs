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

}
