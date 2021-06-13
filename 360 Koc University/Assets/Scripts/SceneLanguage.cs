using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLanguage : MonoBehaviour
{
    public GameObject mainCanvas;

    public GameObject boyMentor;
    public GameObject girlMentor;

    public GameObject mapCanvasTurkish;
    public GameObject mapCanvasEnglish;

    public GameObject settingsCanvasTurkish;
    public GameObject settingsCanvasEnglish;

    public GameObject settingsButtonTurkish;
    public GameObject settingsButtonEnglish;

    private bool isLanguageTurkish = false;
    private bool isLanguageEnglish = false;

    // Start is called before the first frame update
    void Start()
    {
        isLanguageTurkish = GameManager.isTurkishLangaugeSelected;
        isLanguageEnglish = GameManager.isEnglishLanguageSelected;

        if (isLanguageTurkish)
        {
            Destroy(boyMentor);
            girlMentor.SetActive(true);
            Destroy(mapCanvasEnglish);
            Destroy(settingsCanvasEnglish);
            Destroy(settingsButtonEnglish);
        }

        if (isLanguageEnglish)
        {
            boyMentor.SetActive(true);
            Destroy(girlMentor);
            Destroy(mapCanvasTurkish);
            Destroy(settingsCanvasTurkish);
            Destroy(settingsButtonTurkish);
        }

        if (GameManager.isTutorialCompleted)
        {
            mainCanvas.SetActive(true);
        }
    }
}