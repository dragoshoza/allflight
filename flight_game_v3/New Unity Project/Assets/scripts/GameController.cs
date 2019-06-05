using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameStatsUI;

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameStatsUI.SetActive(true);
    }

    public void GameOver()
    {
        gameStatsUI.SetActive(false);
        gameOverUI.SetActive(true);
        Invoke("LoadBegining",3.0f);
    }

    void LoadBegining()
    {
        SceneManager.LoadScene("start_screen");
    }
}
