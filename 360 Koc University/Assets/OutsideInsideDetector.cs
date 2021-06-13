using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideInsideDetector : MonoBehaviour
{
    public GameObject birdSounds;

    void Update()
    {
        if (GameManager.isPlayerOutside && GameManager.isBirdSoundActive)
        {
            birdSounds.SetActive(true);
        } else
        {
            birdSounds.SetActive(false);
        }
    }

    public void playerGoesInside()
    {
        GameManager.isPlayerOutside = false;
    }

    public void playerGoesOutside()
    {
        GameManager.isPlayerOutside = true;
    }
}
