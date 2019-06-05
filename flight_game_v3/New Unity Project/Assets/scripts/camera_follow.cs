using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform target;
    public float speed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        offset = new Vector3(0, 2, -5);
    }

    void LateUpdate()
    {
        transform.position = target.position+offset;
        //Camera.main.transform.LookAt(transform.position + transform.forward);
    }
}
