using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LanguageSelectionButtons : MonoBehaviour
{
    // Turkish Button clicked
    public void LoadSceneWithTurkishLang()
    {
        SceneManager.LoadScene("Tutorial");
        Destroy(GameObject.FindWithTag("EnglishText"));
    }


    // English Button clicked
    public void LoadSceneWithEnglishLang()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void DestroyTurkishText()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("TurkishText");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
    }
}
