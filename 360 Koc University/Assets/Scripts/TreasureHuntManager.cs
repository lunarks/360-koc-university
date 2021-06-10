using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHuntManager : MonoBehaviour
{
    public GameObject trophyObject;
    public GameObject staplerObject;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isTrophyCollected)
        {
            Destroy(trophyObject);
        }

        if (GameManager.isStaplerCollected)
        {
            Destroy(staplerObject);
        }
    }
}



