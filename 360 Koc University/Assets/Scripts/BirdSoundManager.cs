using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSoundManager : MonoBehaviour
{
    public GameObject turnOnBirdSoundsButtonEnglish;
    public GameObject turnOffBirdSoundsButtonEnglish;

    public GameObject turnOnBirdSoundsButtonTurkish;
    public GameObject turnOffBirdSoundsButtonTurkish;

    private void Update()
    {
        if (GameManager.isEnglishLanguageSelected)
        {
            if (GameManager.isBirdSoundActive)
            {
                turnOffBirdSoundsButtonEnglish.SetActive(true);
                turnOnBirdSoundsButtonEnglish.SetActive(false);
            }

            if (GameManager.isBirdSoundActive == false)
            {
                turnOffBirdSoundsButtonEnglish.SetActive(false);
                turnOnBirdSoundsButtonEnglish.SetActive(true);
            }
        }

        if (GameManager.isTurkishLangaugeSelected)
        {
            if (GameManager.isBirdSoundActive)
            {
                turnOffBirdSoundsButtonTurkish.SetActive(true);
                turnOnBirdSoundsButtonTurkish.SetActive(false);
            }

            if (GameManager.isBirdSoundActive == false)
            {
                turnOffBirdSoundsButtonTurkish.SetActive(false);
                turnOnBirdSoundsButtonTurkish.SetActive(true);
            }
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
