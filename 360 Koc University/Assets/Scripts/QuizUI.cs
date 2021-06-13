using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;
    [SerializeField] private Text questionText, scoreText, timerText;
    [SerializeField] private List<Image> lifeImageList;
    [SerializeField] private GameObject gameOverPanel, mainMenuPanel, gameMenuPanel, congratsPanel;
    [SerializeField] private Image questionImage;
    [SerializeField] private List<Button> options, uiButton;
    [SerializeField] private Color correctCol, wrongCol, normalCol; //color of buttons
    

    private Question question;          //store current question data
    private bool answered;


    public Text TimerText { get => timerText; }                     //getter
    public Text ScoreText { get => scoreText; }                     //getter

    public GameObject GameOverPanel { get => gameOverPanel; }
    public GameObject CongratsPanel { get => congratsPanel; }
    public GameObject GamePanel { get => gameMenuPanel; }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

        for (int i = 0; i < uiButton.Count; i++)
        {
            Button localBtn = uiButton[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }

    }

    public void SetQuestion(Question question)
    {
        //set the question
        this.question = question;
        //check for questionType
        switch (question.questionType)
        {
            case QuestionType.TEXT:
                questionImage.transform.parent.gameObject.SetActive(false);   //deactivate image holder
                break;
            case QuestionType.IMAGE:
                questionImage.transform.parent.gameObject.SetActive(true);    //activate image holder
                questionImage.transform.gameObject.SetActive(true);           //activate questionImg
                

                questionImage.sprite = question.questionImage;
                break;
        }

        questionText.text = question.questionInfo;                      //set the question text

        //suffle the list of options
        List<string> ansOptions = ShuffleList.ShuffleListItems<string>(question.options);

        //assign options to respective option buttons
        for (int i = 0; i < options.Count; i++)
        {
            //set the child text
            options[i].GetComponentInChildren<Text>().text = ansOptions[i];
            options[i].name = ansOptions[i];    //set the name of button
            options[i].image.color = normalCol; //set color of button to normal
        }

        answered = false;

    }


    void OnClick(Button btn)
    {
        if (quizManager.GameStatus == GameStatus.PLAYING)
        {
            //if answered is false
            if (!answered)
            {
                //set answered true
                answered = true;
                //get the bool value
                bool val = quizManager.Answer(btn.name);

                //if its true
                if (val)
                {
                    //set color to correct
                    btn.image.color = correctCol;
                }
                else
                {
                    //else set it to wrong color
                    btn.image.color = wrongCol;
                }
            }
        }

        switch (btn.name)
        {
            case "StartButton":
                quizManager.StartGame(0);
                mainMenuPanel.SetActive(false);
                gameMenuPanel.SetActive(true);
                break;

        }

        
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ReduceLife(int index)
    {
        lifeImageList[index].color = normalCol;
    }

}
