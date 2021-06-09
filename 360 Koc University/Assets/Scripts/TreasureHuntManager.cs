using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHuntManager : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject trophyObject;
    public GameObject staplerObject;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().isTrophyCollected)
        {
            Destroy(trophyObject);
        }

        if (gameManager.GetComponent<GameManager>().isStaplerCollected)
        {
            Destroy(staplerObject);
        }
    }
}
