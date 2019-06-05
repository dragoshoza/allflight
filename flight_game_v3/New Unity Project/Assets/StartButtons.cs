using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtons : MonoBehaviour
{
    public Button playButton, instructionButton, helpButton;

    private void Start()
    {
        playButton.onClick.AddListener(TaskOnClickPlay);
        instructionButton.onClick.AddListener(TaskOnClickInstruction);
        helpButton.onClick.AddListener(TaskOnClickHelp);
    }

    void TaskOnClickPlay()
    {
        SceneManager.LoadScene("selection_screen");
    }

    void TaskOnClickInstruction()
    {
        SceneManager.LoadScene("controls");
    }

    void TaskOnClickHelp()
    {
        SceneManager.LoadScene("help");
    }

}
