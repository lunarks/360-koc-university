using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSoundManager : MonoBehaviour
{
    public GameObject birdSound;

    void Update()
    {
        if (GameManager.isBirdSoundActive)
        {
            birdSound.SetActive(true);
        } else
        {
            birdSound.SetActive(false);
        }
    }

    public void turnOffBirdSounds()
    {
        GameManager.isBirdSoundActive = false;
    }

    public void turnOnBirdSounds()
    {
        GameManager.isBirdSoundActive = true;
    }
}
