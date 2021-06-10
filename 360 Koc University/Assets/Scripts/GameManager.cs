using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Singleton Pattern
    // Makes the instance accessible by any script
    // public static GameManager instance = null;

    static public bool isTrophyCollected = false;
    static public bool isStaplerCollected = false;

    static public bool isTurkishLangaugeSelected = false;
    static public bool isEnglishLanguageSelected = false;
}
