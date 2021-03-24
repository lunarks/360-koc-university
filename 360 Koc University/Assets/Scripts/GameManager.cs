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
    public static GameManager instance = null;

    // Language Selection Screen objects
    private Button turkishButton;
    private Button englishButton;

    void Awake()
    {
        if (instance = null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
