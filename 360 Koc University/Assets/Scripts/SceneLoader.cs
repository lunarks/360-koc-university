using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Loads the mini-quiz game
    public void LoadQuizGame()
    {
        if (GameManager.isTurkishLangaugeSelected)
        {
            SceneManager.LoadScene("QuizTurkish");
        }

        if (GameManager.isEnglishLanguageSelected)
        {
            SceneManager.LoadScene("QuizEnglish");
        }
    }

    // Load language selection and reset the game
    public void ResetGame()
    {
        GameManager.isTrophyCollected = false;
        GameManager.isStaplerCollected = false;
        GameManager.isTurkishLangaugeSelected = false;
        GameManager.isEnglishLanguageSelected = false;
        GameManager.isTutorialCompleted = false;
        GameManager.isBirdSoundActive = true;
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("LanguageSelection");
    }

    // Bus Stop
    public void LoadBusStop()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Bus Stop");
        Debug.Log("Loaded the Bus Stop scene.");
    }

    // CASE Indoors
    public void LoadCASEIndoors()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("CASE_Indoors");
        Debug.Log("Loaded the CASE Indoors scene.");
    }

    // CASE Outdoors
    public void LoadCASEOutdoors()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CASE_Outdoors");
        Debug.Log("Loaded the CASE Outdoors scene.");
    }

    // Center
    public void LoadCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Center");
        Debug.Log("Loaded the Center scene.");
    }

    // Dormitory
    public void LoadDormitory()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Dormitory");
        Debug.Log("Loaded the Dormitory scene.");
    }



    // ELC
    public void LoadELC()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ELC");
        Debug.Log("Loaded the ELC scene.");
    }


    // ENG
    public void LoadENG()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ENG");
        Debug.Log("Loaded the ENG scene.");
    }



    // Health Center
    public void LoadHealthCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("HealthCenter");
        Debug.Log("Loaded the HealthCenter scene.");
    }

    // Henry Ford
    public void LoadHenryFord()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("HenryFord");
        Debug.Log("Loaded the HenryFord scene.");
    }

  

    // Odeon
    public void LoadOdeon()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Odeon");
        Debug.Log("Loaded the Odeon scene.");
    }

    // Parking Lot
    public void LoadParkingLot()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ParkingLot");
        Debug.Log("Loaded the Parking Lot scene.");
    }

    // Portal of Knowledge
    public void LoadPortalOfKnowledge()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("PortalOfKnowledge");
        Debug.Log("Loaded the Portal of Knowledge scene.");
    }

    // Road to Center
    public void LoadRoadtoCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadToCenter");
        Debug.Log("Loaded the Road to Center scene.");
    }

    // Road to Gym
    public void LoadRoadtoGym()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadtoGym");
        Debug.Log("Loaded the Road to Gym scene.");
    }

    // Gym
    public void LoadSAG()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SAG");
        Debug.Log("Loaded the gym scene.");
    }

    // S Dormitory
    public void LoadSDormitory()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SDormitory");
        Debug.Log("Loaded the S Dormitory scene.");
    }

    // SGKM
    public void LoadSGKM()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SGKM");
        Debug.Log("Loaded the SGKM scene.");
    }

    // SKL
    public void LoadSKL()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SKL");
        Debug.Log("Loaded the library scene.");
    }

    // SNA
    public void LoadSNA()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SNA");
        Debug.Log("Loaded the SNA scene.");
    }

    // SOS
    public void LoadSOS()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SOS");
        Debug.Log("Loaded the SOS scene.");
    }

    // Student Center
    public void LoadStudentCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("StudentCenter");
        Debug.Log("Loaded the StudentCenter scene.");
    }

    // Tower
    public void LoadTower()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("Tower");
        Debug.Log("Loaded the Tower scene.");
    }

    // Tunnel
    public void LoadTunnel()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("Tunnel");
        Debug.Log("Loaded the Tunnel scene.");
    }
}
