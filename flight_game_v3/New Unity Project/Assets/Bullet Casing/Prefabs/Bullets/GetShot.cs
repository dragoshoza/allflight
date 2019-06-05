using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetShot : MonoBehaviour
{

    public Text scoreText;
    public SimpleHealthBar healthBar;
    public GameController gc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            this.gameObject.GetComponent<ParticleSystem>().Play();
            //Destroy(this.gameObject);
            PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score") + 1);
            scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        }
        else if (other.gameObject.CompareTag("Player"))
        {

            Destroy(this.gameObject);
            int health = PlayerPrefs.GetInt("Health");
            health= health - 5;
            PlayerPrefs.SetInt("Health",health);
            healthBar.UpdateBar(health,100);
            if (health < 0)
            {
                gc.GameOver();
            }
        }
    }


}
