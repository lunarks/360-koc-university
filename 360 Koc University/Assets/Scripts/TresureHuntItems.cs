using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureHuntItems : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject englishTexts;
    public GameObject turkishTexts;

    public GameObject trophyQuestionMark;
    public GameObject trophyModel;

    public GameObject staplerQuestionMark;
    public GameObject staplerModel;


    private bool trophy;
    private bool stapler;
    private bool turkish;
    private bool english;

    // Start is called before the first frame update
    void Start()
    {
        trophy = gameManager.GetComponent<GameManager>().isTrophyCollected;
        stapler = gameManager.GetComponent<GameManager>().isStaplerCollected;
        turkish = gameManager.GetComponent<GameManager>().isTurkishLangaugeSelected;
        english = gameManager.GetComponent<GameManager>().isEnglishLanguageSelected;
    }

    // Update is called once per frame
    void Update()
    {
        if (turkish)
        {
            turkishTexts.SetActive(true);
            englishTexts.SetActive(false);
        }

        if (englishTexts)
        {
            turkishTexts.SetActive(false);
            englishTexts.SetActive(true);
        }

        if (trophy)
        {
            trophyQuestionMark.SetActive(false);
            trophyModel.SetActive(true);
        }

        if (stapler)
        {
            staplerQuestionMark.SetActive(false);
            staplerModel.SetActive(true);
        }
    }
}
