using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    float maxSpeed = 50.0f;
    string accelKey = "w";
    string leftKey = "left";
    string rightKey = "right";
    string upKey = "up";
    string downKey = "down";
    float accel = 1.2f;
    float decel = 0.8f;
    float upDownSpeed = 20.0f;
    float turnSpeed = 20.0f;
    float speedToFly = 40.0f;
     GameObject cam;
     GameObject groundDetector;
     GameObject explosion;
    private float curSpeed = 0.0f;
    private float curFall = 0.0f;
    private bool isFalling = false;
    static bool isGrounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFalling == false)
        {
            if (Input.GetKeyDown(accelKey))
            {
                curSpeed++;
            }
            if (Input.GetKey(accelKey))
            {
                curSpeed += accel * Time.deltaTime;
            }
        }
        else
        {
            curSpeed--;
        }
        if (Input.GetKey(accelKey))
        {
        }
        else
        {
            if (isGrounded == false)
            {
                curSpeed -= decel * Time.deltaTime;
            }
            if (isGrounded == true)
            {
                curSpeed -= (decel * 2) * Time.deltaTime;
            }
        }
        if (curSpeed > maxSpeed)
        {
            curSpeed = maxSpeed;
        }
        if (curSpeed < 0)
        {
            curSpeed = 0;
        }
        if (isGrounded == true)
        {
            if (curSpeed < speedToFly)
            {
                Quaternion newPos = new Quaternion(0, transform.rotation.y, 0,transform.rotation.w);
                transform.rotation = newPos;

            }
        }
        if (isGrounded == false)
        {
            if (curSpeed < speedToFly)
            {
                curFall += 9.8f * Time.deltaTime;
                transform.Translate(Vector3.down * curFall * Time.deltaTime);
                if (transform.position.y > 50)
                {
                    groundDetector.SetActive(false);
                    isFalling = true;
                }
            }
        }
        transform.Translate(Vector3.forward * curSpeed * Time.deltaTime);
        if (Input.GetKey(upKey))
        {
            if (curSpeed >= speedToFly)
            {
                transform.Rotate(Vector3.right * (-1 * upDownSpeed) * Time.deltaTime);
            }
        }
        if (Input.GetKey(leftKey))
        {
            transform.Rotate(Vector3.up * (-1 * turnSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(rightKey))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(downKey))
        {
            transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime);
        }
        print(curSpeed);
    }
}
