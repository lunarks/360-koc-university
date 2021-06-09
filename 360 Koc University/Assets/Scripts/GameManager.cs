using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class GameManager : MonoBehaviour
{
    // Singleton Pattern
    // Makes the instance accessible by any script
    public static GameManager instance = null;

    public bool isTrophyCollected = false;
    public bool isStaplerCollected = false;

    public bool isTurkishLangaugeSelected = false;
    public bool isEnglishLanguageSelected = false;

    void Awake()
    {
        // Handling the GameManager script
        if (instance = null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
