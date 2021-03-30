using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadMap()
    {
        SceneManager.LoadScene("University Map");
    }

    public void LoadOdeon()
    {
        SceneManager.LoadScene("QuizScreen");
    }
}
