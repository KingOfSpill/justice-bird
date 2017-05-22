using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    // Variables for movement speed
    public float movspeed = 2;
    public float rotspeed = 60;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        // Convert the user input into the amount of rotation wo want to do
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * rotspeed;
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * rotspeed;

        // Perform the rotation
        transform.Rotate(new Vector3(vertical, horizontal , -0.2f * horizontal) );

        //Rotate back to horizontal if there's no input
        /*if (Input.GetAxisRaw("Horizontal") == 0) {

            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - System.Math.Abs(transform.rotation.eulerAngles.z/20)*(rotspeed*Time.deltaTime) );

        }*/

        // Move the bird forward
        transform.position += transform.forward * movspeed;

        // Doing this to keep the  camera level to the ground
        Camera.main.transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, 0);

	}
}
