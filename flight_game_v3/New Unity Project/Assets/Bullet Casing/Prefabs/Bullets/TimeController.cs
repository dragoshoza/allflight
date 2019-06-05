using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Text timeRemaining;
    public string nextScene;
    public float timeRemainingValue;

    void Start()
    {
        timeRemaining.text = "60";
        timeRemainingValue = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemainingValue < 0) SceneManager.LoadScene(nextScene);
        timeRemaining.text = (float.Parse(timeRemaining.text)-Time.deltaTime).ToString();
        timeRemainingValue = timeRemainingValue - Time.deltaTime;
    }
}
