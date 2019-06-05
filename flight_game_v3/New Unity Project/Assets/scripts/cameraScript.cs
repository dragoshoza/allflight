using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{

    [AddComponentMenu("Camera-Control/Mouse Look")]
    public class MouseLookScript : MonoBehaviour
    {
        public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
        public RotationAxes axes = RotationAxes.MouseXAndY;

        public float sensitivityX = 10F;
        public float sensitivityY = 10F;

        public float minimumX = -360F;
        public float maximumX = 360F;

        public float minimumY = -60F;
        public float maximumY = 60F;

        float rotationY = 0F;

        void Start()
        {
            // Make the rigid body not change rotation
            if (GetComponent<Rigidbody>())
                GetComponent<Rigidbody>().freezeRotation = true;
        }

        //lateUpdate(); ?
        void Update()
        {
            transform.position += transform.forward * Time.deltaTime * 10.0f;
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Time.deltaTime * 10f);
           // transform.position += transform.forward * Time.deltaTime * 10.0f;
            if (Input.GetButton("Fire1"))
                transform.position += transform.forward * Time.deltaTime * 40.0f;

            transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

            float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

            if (terrainHeightWhereWeAre > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x,
                terrainHeightWhereWeAre,
                transform.position.z);
            }
        }
    }
}
