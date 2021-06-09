using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHuntManager : MonoBehaviour
{
    public GameObject gameManager;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().isTrophyCollected)
        {
            
        }
    }
}
