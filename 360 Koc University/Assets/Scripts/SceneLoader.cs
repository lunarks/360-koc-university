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

    public void LoadELC()
    {
        SceneManager.LoadScene("ELC");
        Debug.Log("Loaded the ELC scene.");
    }

    public void LoadBusStop()
    {
        SceneManager.LoadScene("Bus Stop");
        Debug.Log("Loaded the Bus Stop scene.");
    }

    public void LoadRoadtoGym()
    {
        SceneManager.LoadScene("RoadtoGym");
        Debug.Log("Loaded the Road to Gym scene.");
    }


    public void LoadCenter()
    {
        SceneManager.LoadScene("Center");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadRoadtoCenter()
    {
        SceneManager.LoadScene("RoadToCenter");
        Debug.Log("Loaded the Road to Center scene.");

    }

    public void LoadSOS()
    {
        SceneManager.LoadScene("SOS");
        Debug.Log("Loaded the SOS scene.");

    }

    public void LoadHealthCenter()
    {
        SceneManager.LoadScene("HealthCenter");
        Debug.Log("Loaded the HealthCenter scene.");

    }

}
