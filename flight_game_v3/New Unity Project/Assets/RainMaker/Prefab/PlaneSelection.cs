using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class PlaneSelection : MonoBehaviour
    {
        public List<GameObject> planes = new List<GameObject>();
        public static int selection = 0;

        private void Start()
        {
            foreach (GameObject go in planes)
            {
                go.SetActive(false);
            }

            
            planes[selection].SetActive(true);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                planes[selection].SetActive(false);
                selection++;
                if (selection >= planes.Count) selection = 0;
                planes[selection].SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                planes[selection].SetActive(false);
                selection--;
                if (selection < 0) selection = planes.Count - 1;
                planes[selection].SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("airport_scene");

            }
        }
    }
