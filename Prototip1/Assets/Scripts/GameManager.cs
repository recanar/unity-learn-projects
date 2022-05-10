using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public int score = 0;
    public static GameManager instance;
    public bool isFinished;
    private void Awake()
    {
        if (instance== null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (!isFinished) Timer();
    }
    public void IncreasePoint()
    {
        score++;
        scoreText.text = "score:"+Convert.ToString(score);
    }
    private void Timer()
    {
        timerText.text = "Time:" + ((int)Time.unscaledTime).ToString()+ " sec.";
    }
}
