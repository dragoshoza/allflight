using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour
{
    public float speed = 90.0f;
    public float rotateAmount = 2.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;
        float bias = 0.96f;

        Camera.main.transform.position = Camera.main.transform.position*bias+moveCamTo*(1-bias);
        Camera.main.transform.LookAt(transform.position + transform.forward);
        transform.position += transform.forward * Time.deltaTime * speed;
        speed -= transform.forward.y * Time.deltaTime * speed;
        transform.Rotate(Input.GetAxis("Vertical"),0.0f,-Input.GetAxis("Horizontal"));
    }
}

