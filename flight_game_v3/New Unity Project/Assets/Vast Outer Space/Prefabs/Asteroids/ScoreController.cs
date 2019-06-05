using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public int score;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString();
    }

}
