using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLanguage : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject boyMentor;
    public GameObject girlMentor;

    private bool isLanguageTurkish = false;
    private bool isLanguageEnglish = false;

    // Start is called before the first frame update
    void Start()
    {
        isLanguageTurkish = gameManager.GetComponent<GameManager>().isTurkishLangaugeSelected;
        isLanguageEnglish = gameManager.GetComponent<GameManager>().isEnglishLanguageSelected;

        if (isLanguageTurkish)
        {
            boyMentor.SetActive(false);
            girlMentor.SetActive(true);
        }


        if (isLanguageEnglish)
        {
            boyMentor.SetActive(true);
            girlMentor.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLanguageTurkish)
            boyMentor.SetActive(false);

        if (isLanguageEnglish)
            girlMentor.SetActive(false);
    }
}