using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_control : MonoBehaviour
{

    private Rigidbody rigidbody;
    // Use this for initialization

    public float AmbientSpeed = 100.0f;

    public float RotationSpeed = 200.0f;

    void Start()
    {
        Debug.Log("Fly script added to: " + gameObject.name);
        rigidbody = GetComponent<Rigidbody>();
    }

    

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * AmbientSpeed;
        rigidbody.MovePosition(rigidbody.position + transform.forward * Time.deltaTime * AmbientSpeed);
        if (Input.GetButton("Fire1"))
            transform.position += transform.forward * Time.deltaTime * 40.0f;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

    }
}


