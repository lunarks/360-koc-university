using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Turkish
    public GameObject tutorialCanvasTurkish;
    public GameObject[] turkishElements;

    // English
    public GameObject tutorialCanvasEnglish;
    public GameObject[] englishElements;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.isTutorialCompleted == false)
        {
            DestoryOtherTutorial();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isTutorialCompleted == true)
        {
            Destroy(gameObject);
        }

        if (GameManager.isTurkishLangaugeSelected)
        {
            StartTurkishTutorial();
        }

        if (GameManager.isEnglishLanguageSelected)
        {
            StartEnglishTutorial();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed space!");
            count++;
        }
            
    }

    private void DestoryOtherTutorial()
    {
        if (GameManager.isEnglishLanguageSelected)
        {
            Debug.Log("Destroyed the Turkish canvas.");
            Destroy(tutorialCanvasTurkish);
        }

        if (GameManager.isTurkishLangaugeSelected)
        {
            Debug.Log("Destroyed the English canvas.");
            Destroy(tutorialCanvasEnglish);
        }
    }

    private void StartTurkishTutorial()
    {
        switch(count)
        {
            case 0:
                turkishElements[count].SetActive(true);
                break;

            case 1:
                turkishElements[count - 1].SetActive(false);
                turkishElements[count].SetActive(true);
                break;

            case 2:
                turkishElements[count - 1].SetActive(false);
                turkishElements[count].SetActive(true);
                break;

            case 3:
                turkishElements[count - 1].SetActive(false);
                turkishElements[count].SetActive(true);
                break;

            case 4:
                turkishElements[count - 1].SetActive(false);
                turkishElements[count].SetActive(true);
                break;

            case 5:
                GameManager.isTutorialCompleted = true;
                break;
        } 
    }

    private void StartEnglishTutorial()
    {
        switch (count)
        {
            case 0:
                englishElements[count].SetActive(true);
                break;

            case 1:
                englishElements[count - 1].SetActive(false);
                englishElements[count].SetActive(true);
                break;

            case 2:
                englishElements[count - 1].SetActive(false);
                englishElements[count].SetActive(true);
                break;

            case 3:
                englishElements[count - 1].SetActive(false);
                englishElements[count].SetActive(true);
                break;

            case 4:
                englishElements[count - 1].SetActive(false);
                englishElements[count].SetActive(true);
                break;

            case 5:
                GameManager.isTutorialCompleted = true;
                break;
        }
    }


}
