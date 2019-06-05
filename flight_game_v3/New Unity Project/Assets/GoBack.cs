using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    public Button goBack;
    
    void Start()
    {
        goBack.onClick.AddListener(OnClickTask);
    }

    void OnClickTask()
    {
        SceneManager.LoadScene("start_screen");
    }

}
