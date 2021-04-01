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

    void Awake()
    {
        // Handling the GameManager script
        if (instance = null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        isTrophyCollected();
        isStaplerCollected();
    }

    private bool isTrophyCollected()
    {
        if (GameObject.Find("Trophy") == null)
        {
            Debug.Log("Trophy collected.");
            GameObject gymX = GameObject.Find("Gym X");
            Destroy(gymX);
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool isStaplerCollected()
    {
        if (GameObject.Find("Stapler") == null)
        {
            GameObject libX = GameObject.Find("Library X");
            Destroy(libX);
            return true;
        }
        else
        {
            return false;
        }
    }




}
