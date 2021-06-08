using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    public GameObject gameManager;

    /*
     * Checks which language was selected and changes the game texts accordingly.
     */
    public void ActivateTurkishLanguage()
    {
        Debug.Log("Loading the application in Turkish.");
        gameManager.GetComponent<GameManager>().isTurkishLangaugeSelected = true;
        gameManager.GetComponent<GameManager>().isEnglishLanguageSelected = false;
        // LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("tr");
    }

    public void ActivateEnglishLanguage()
    {
        Debug.Log("Loading the application in English.");
        gameManager.GetComponent<GameManager>().isEnglishLanguageSelected = true;
        gameManager.GetComponent<GameManager>().isTurkishLangaugeSelected = false;
        // LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("en");
    }
}
