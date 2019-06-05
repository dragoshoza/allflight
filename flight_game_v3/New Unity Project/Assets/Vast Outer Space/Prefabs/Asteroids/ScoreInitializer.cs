using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInitializer : MonoBehaviour
{
  
    void Start()
    {
        PlayerPrefs.SetInt("Score",0);
    }

   
}
