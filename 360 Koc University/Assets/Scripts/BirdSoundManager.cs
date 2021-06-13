using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSoundManager : MonoBehaviour
{
    public void turnOffBirdSounds()
    {
        GameManager.isBirdSoundActive = false;
    }

    public void turnOnBirdSounds()
    {
        GameManager.isBirdSoundActive = true;
    }
}
