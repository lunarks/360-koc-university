using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private QuizUI quizUI;
    [SerializeField] private List<QuizDataScriptable> quizData;
    [SerializeField] private float timeLimit = 30f;

    private List<Question> questions;
    //current question data
    private Question selectedQuestion;
    private int scoreCount = 0;
    private float currentTime;
    private int lifeRemaining = 3;


    private GameStatus gameStatus = GameStatus.NEXT;
    public GameStatus GameStatus { get { return gameStatus; } }


    // Start is called before the first frame update
    public void StartGame(int index)
    {
        scoreCount = 0;
        currentTime = timeLimit;
        lifeRemaining = 3;
        questions = new List<Question>();

        for (int i = 0; i < quizData[index].questions.Count; i++)
        {
            questions.Add(quizData[index].questions[i]);
        }

        
        SelectQuestion();

        gameStatus = GameStatus.PLAYING;
    }

    void SelectQuestion()
    {
        //get the random number
        int val = UnityEngine.Random.Range(0, questions.Count);
        
        //set the selectedQuetion
        selectedQuestion = questions[val];
        //send the question to quizGameUI
        quizUI.SetQuestion(selectedQuestion);

        questions.RemoveAt(val);

    }

    private void Update()
    {
        if (gameStatus == GameStatus.PLAYING)
        {
            currentTime -= Time.deltaTime;
            SetTimer(currentTime);
        }
    }

    private void SetTimer(float value)
    {
        TimeSpan time = TimeSpan.FromSeconds(value);
        quizUI.TimerText.text = "Time: " + time.ToString("mm':'ss");

        if (currentTime <= 0)
        {
            gameStatus = GameStatus.NEXT;
            quizUI.GamePanel.SetActive(false);
            quizUI.GameOverPanel.SetActive(true);
        }
    }

    public bool Answer(string answered)
    {
        //set default to false
        bool correctAns = false;
 
        //if selected answer is similar to the correctAns
        if (answered == selectedQuestion.correctAns)
        {
            correctAns = true;
            scoreCount += 50;
            quizUI.ScoreText.text = "Score: " + scoreCount;
            
        }
        else
        {
            lifeRemaining--;
            quizUI.ReduceLife(lifeRemaining);

            if(lifeRemaining == 0)
            {
                gameStatus = GameStatus.NEXT;
                quizUI.GamePanel.SetActive(false);
                quizUI.GameOverPanel.SetActive(true);
            }
        }

        if (gameStatus == GameStatus.PLAYING)
        {
            if (questions.Count > 0)
            {
                Invoke("SelectQuestion", 0.4f);
            }
            else
            {
                gameStatus = GameStatus.NEXT;
                quizUI.GamePanel.SetActive(false);
                quizUI.GameOverPanel.SetActive(true);
            }
        }

        if (scoreCount == 250  && lifeRemaining != 0)
        {
            gameStatus = GameStatus.NEXT;
            quizUI.GamePanel.SetActive(false);
            quizUI.CongratsPanel.SetActive(true);
        }

        //return the value of correct bool
        return correctAns;
    }
}

[System.Serializable]
public class Question
{
    public string questionInfo;         //question text
    public QuestionType questionType;   //type
    public Sprite questionImage;        //image for Image Type
    public List<string> options;        //options to select
    public string correctAns;           //correct option
}

[System.Serializable]
public enum QuestionType
{
    TEXT,
    IMAGE
}


[SerializeField]
public enum GameStatus
{
    PLAYING,
    NEXT
}
