using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText, highScoreText, gameOverScoreText;
    public int score, highScore;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        highScore = 0;
        scoreText.text = "SCORE:  " + score.ToString();
    }

    public void AddScore() {
        score++;
        scoreText.text = "SCORE:  " + score.ToString();
        UpdateHighScore();
        //gameOverScoreText.text = score.ToString();

    }

    public void UpdateHighScore()
    {
        if(score > highScore)
        {
            highScore = score;

            highScoreText.text = "HIGH SCORE:  " + highScore.ToString();
        }
    }
}
