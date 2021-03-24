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
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("tr");
    }

    public void ActivateEnglishLanguage()
    {
        Debug.Log("Loading the application in English.");
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("en");
    }
}
