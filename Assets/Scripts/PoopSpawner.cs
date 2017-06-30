using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoopSpawner : MonoBehaviour
{
    public float speed;
    public float tilt;

    public GameObject Poop;
    //public Transform buttHole;
    public float fireRate;

    private float nextFire;

    void Update ()
    {
        if (Input.GetButton("Fire1") || Input.GetKeyDown("space"))
        {
            
            Instantiate(Poop, transform.position, transform.rotation);
        }
    }

   /* void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3 
        (
            Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
            0.0f, 
            Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
        );

        rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    }*/
}