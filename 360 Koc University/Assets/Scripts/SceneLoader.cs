using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Loaded the tutorial scene.");
    }

    public void LoadOdeon()
    {
        SceneManager.LoadScene("QuizScreen");
        Debug.Log("Loaded the odeon scene.");
    }

    public void LoadSKL()
    {
        SceneManager.LoadScene("SKL");
        Debug.Log("Loaded the library scene.");
    }

    public void LoadSAG()
    {
        SceneManager.LoadScene("SAG");
        Debug.Log("Loaded the gym scene.");
    }
}
