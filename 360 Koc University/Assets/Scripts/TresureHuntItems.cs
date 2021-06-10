using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureHuntItems : MonoBehaviour
{
    // Canvas Texts
    public GameObject englishTexts;
    public GameObject turkishTexts;

    // Trophy
    public GameObject trophyQuestionMark;
    public GameObject trophyModel;

    // Stapler
    public GameObject staplerQuestionMark;
    public GameObject staplerModel;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isTurkishLangaugeSelected)
        {
            turkishTexts.SetActive(true);
            englishTexts.SetActive(false);
        }

        if (GameManager.isEnglishLanguageSelected)
        {
            turkishTexts.SetActive(false);
            englishTexts.SetActive(true);
        }

        if (GameManager.isTrophyCollected)
        {
            trophyQuestionMark.SetActive(false);
            trophyModel.SetActive(true);
        }
    }
}
