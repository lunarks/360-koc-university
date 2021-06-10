using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    /*
     * Checks which language was selected and changes the game texts accordingly.
     */
    public void ActivateTurkishLanguage()
    {
        Debug.Log("Loading the application in Turkish.");
        GameManager.isTurkishLangaugeSelected = true;
        GameManager.isEnglishLanguageSelected = false;
    }

    public void ActivateEnglishLanguage()
    {
        Debug.Log("Loading the application in English.");
        GameManager.isTurkishLangaugeSelected = false;
        GameManager.isEnglishLanguageSelected = true;
    }
}
