using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject go;
    void OnTriggerEnter(Collider other)
    {
        
        Destroy(go);
    }
}
