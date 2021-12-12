using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;

    private int score;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        scoreText.text = "SCORE " + score.ToString();    
    }

    public void AddPoint() {
        score += 1;
        scoreText.text = "SCORE " + score.ToString();    

    }
}
