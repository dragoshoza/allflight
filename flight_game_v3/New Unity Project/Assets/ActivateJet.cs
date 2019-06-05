using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateJet : MonoBehaviour
{
    public List<GameObject> planes;
    
    void Start()
    {
          foreach (GameObject go in planes)
        {
            go.SetActive(false);
        }
        planes[PlaneSelection.selection].SetActive(true);
    }

    
}
