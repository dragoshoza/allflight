using UnityEngine;

public class BulletShot : MonoBehaviour
{
    public GameObject projectile;

    public float speed = 80;

    private AudioSource audioSource;
    public AudioClip Scored;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play(); //play explosion sound

            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.tag = "Bullet";
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);

        }
    }

}