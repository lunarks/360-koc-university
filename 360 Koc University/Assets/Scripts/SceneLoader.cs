using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // 360 Video
    public void LoadVideo()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("360Video");
        Debug.Log("Loaded the 360 Video scene.");
    }

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

    public void LoadCASEIndoorsFromSOS()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("CASE_IndoorsFromSOS");
        Debug.Log("Loaded the CASE Indoors scene.");
    }

    public void LoadCASEIndoorsFromOdeonCASEEntrance()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("CASE_IndoorsFromOdeonCASEEntrance");
        Debug.Log("Loaded the CASE Indoors scene.");
    }

    public void LoadCASEIndoorsFromOdeonNero()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("CASE_IndoorsFromOdeonNero");
        Debug.Log("Loaded the CASE Indoors scene.");
    }

    // CASE Outdoors
    public void LoadCASEOutdoors()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CASE_Outdoors");
        Debug.Log("Loaded the CASE Outdoors scene.");
    }

    public void LoadCASEOutdoorsFromSOS()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CASE_OutdoorsFromSOS");
        Debug.Log("Loaded the CASE Outdoors scene.");
    }

    public void LoadCASEOutdoorsFromVideo()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CASE_OutdoorsFromVideo");
        Debug.Log("Loaded the CASE Outdoors scene.");
    }


    // Center
    public void LoadCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Center");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadCenterFromSKL()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromSKL");
        Debug.Log("Loaded the Center scene.");
    }
    
    public void LoadCenterFromTower()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromTower");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadCenterFromHenryFord()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromHenryFord");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadCenterFromCASEOutdoors()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromCASE_Outdoors");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadCenterFromOdeon()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromOdeon");
        Debug.Log("Loaded the Center scene.");
    }

    public void LoadCenterFromRoadToCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("CenterFromRoadToCenter");
        Debug.Log("Loaded the Center scene.");
    }


    // Dormitory
    public void LoadDormitory()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Dormitory");
        Debug.Log("Loaded the Dormitory scene.");
    }

    public void LoadDormitoryFromHCandSD()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("DormitoryFromHCandSD");
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

    public void LoadENGFromParkingLot()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ENGFromParkingLot");
        Debug.Log("Loaded the ENG scene.");
    }

    public void LoadENGFromTunnel()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("ENGFromTunnel");
        Debug.Log("Loaded the ENG scene.");
    }

    public void LoadENGAuditoriumFromSNA()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("ENGAuditoriumFromSNA");
        Debug.Log("Loaded the ENG scene.");
    }

    public void LoadENGLowerFromSNA()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("ENGLowerFromSNA");
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

    public void LoadHenryFordFromDormitory()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("HenryFordFromDormitory");
        Debug.Log("Loaded the HenryFord scene.");
    }

    public void LoadHenryFordFromPortalOfKnowledge()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("HenryFordFromPortalOfKnowledge");
        Debug.Log("Loaded the HenryFord scene.");
    }


    // Odeon
    public void LoadOdeon()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("Odeon");
        Debug.Log("Loaded the Odeon scene.");
    }

    public void LoadOdeonCASEEntranceFromCASEIndoorsandCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("OdeonCASEEntranceFromCASEIndoorsandCenter");
        Debug.Log("Loaded the Odeon scene.");
    }

    public void LoadOdeonFromStudentCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("OdeonFromStudentCenter");
        Debug.Log("Loaded the Odeon scene.");
    }


    // Parking Lot
    public void LoadParkingLot()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ParkingLot");
        Debug.Log("Loaded the Parking Lot scene.");
    }

    public void LoadParkingLotFromELC()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ParkingLotFromELC");
        Debug.Log("Loaded the Parking Lot scene.");
    }

    public void LoadParkingLotFromSGKM()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("ParkingLotFromSGKM");
        Debug.Log("Loaded the Parking Lot scene.");
    }


    // Portal of Knowledge
    public void LoadPortalOfKnowledge()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("PortalOfKnowledge");
        Debug.Log("Loaded the Portal of Knowledge scene.");
    }

    public void LoadPortalOfKnowledgeFromCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("PortalOfKnowledgeFromCenter");
        Debug.Log("Loaded the Portal of Knowledge scene.");
    }


    // Road to Center
    public void LoadRoadtoCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadToCenter");
        Debug.Log("Loaded the Road to Center scene.");
    }

    public void LoadRoadtoCenterFromCenterandPortalOfKnowledge()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadtoCenterFromCenterandPortalOfKnowledge");
        Debug.Log("Loaded the Road to Center scene.");
    }


    // Road to Gym
    public void LoadRoadtoGym()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadtoGym");
        Debug.Log("Loaded the Road to Gym scene.");
    }

    public void LoadRoadtoGymCorner()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("RoadtoGymCorner");
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
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SGKM");
        Debug.Log("Loaded the SGKM scene.");
    }

    public void LoadSGKMFromQuiz()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SGKMFromQuiz");
        Debug.Log("Loaded the SGKM scene.");
    }

    public void LoadSGKMFromCASEIndoorsandSOS()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SGKMFromCASE_IndoorsandSOS");
        Debug.Log("Loaded the SGKM scene.");
    }

    public void LoadSGKMFromCASEOutdoors()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SGKMFromCASE_Outdoors");
        Debug.Log("Loaded the SGKM scene.");
    }

    public void LoadSGKMFromParkingLot()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("SGKMFromParkingLot");
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

    public void LoadSNAFromENG()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SNAFromENG");
        Debug.Log("Loaded the SNA scene.");
    }

    public void LoadSNAFromENGAuditorium()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SNAFromENGAuditorium");
        Debug.Log("Loaded the SNA scene.");
    }


    // SOS
    public void LoadSOS()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SOS");
        Debug.Log("Loaded the SOS scene.");
    }

    public void LoadSOSFromSGKM()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SOSFromSGKM");
        Debug.Log("Loaded the SOS scene.");
    }

    public void LoadSOSFromTunnelandOdeon()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SOSFromTunnelandOdeon");
        Debug.Log("Loaded the SOS scene.");
    }

    public void LoadSOSFromENG()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("SOSFromENG");
        Debug.Log("Loaded the SOS scene.");
    }


    // Student Center
    public void LoadStudentCenter()
    {
        GameManager.isPlayerOutside = true;
        SceneManager.LoadScene("StudentCenter");
        Debug.Log("Loaded the StudentCenter scene.");
    }

    public void LoadStudentCenterFromOdeon()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("StudentCenterFromOdeon");
        Debug.Log("Loaded the StudentCenter scene.");
    }

    public void LoadStudentCenterFromTunnel()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("StudentCenterFromTunnel");
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

    public void LoadTunnelFromSOS()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("TunnelFromSOS");
        Debug.Log("Loaded the Tunnel scene.");
    }

    public void LoadTunnelFromENG()
    {
        GameManager.isPlayerOutside = false;
        SceneManager.LoadScene("TunnelFromENG");
        Debug.Log("Loaded the Tunnel scene.");
    }
}
