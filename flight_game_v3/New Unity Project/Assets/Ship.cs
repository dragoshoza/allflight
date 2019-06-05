using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpaceshipMovement : MonoBehaviour
{
  

    private float thrust = 0;

    private void Update()
    {
        CalculateRotation();
        CalculateThrust();
    }

    private void CalculateRotation()
    {
        float pitch = -Input.GetAxis("Vertical") * Time.deltaTime ;
        float yaw = Input.GetAxis("Horizontal") * Time.deltaTime ;
        float roll = -Input.GetAxis("Roll") * Time.deltaTime ;

        Vector3 keyboardRot = new Vector3(pitch, yaw, roll);

        transform.Rotate(keyboardRot);
    }

    private void CalculateThrust()
    {
        thrust += Input.GetAxis("Thrust") * Time.deltaTime;
        //thrust = Mathf.Clamp(thrust, spaceship.minThrust, spaceship.maxThrust);

        Debug.Log(thrust);

        transform.position += transform.forward * thrust * Time.deltaTime;
    }
}

