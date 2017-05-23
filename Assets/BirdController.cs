using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    // Variables for movement speed
    public float movSpeed = 2;
    public float rotSpeed = 60;

    // This holds the banking container object, which allows us to visually show banking without effecting the whole shapes angle around its z-axis
    public Transform bankingContainer;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        // Convert the user input into the amount of rotation wo want to do
        float verticalMov = Input.GetAxisRaw("Vertical") * Time.deltaTime * movSpeed;
        float vertical = Input.GetAxisRaw("Vertical") * Time.deltaTime * rotSpeed;
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;

        // Perform the rotation
        transform.Rotate( new Vector3(vertical, 0, 0) );
        transform.RotateAround( transform.position ,Vector3.up, horizontal);

        // Let's store these values to make the code below more readable
        float bankXAngle = bankingContainer.eulerAngles.x;
        float bankYAngle = bankingContainer.eulerAngles.y;

        // We want to rotate to preset angles depending on the input we are receiving on the horizontal axis right now
        if ( Input.GetAxisRaw("Horizontal") > 0)
            bankingContainer.rotation = Quaternion.Slerp( bankingContainer.rotation, Quaternion.Euler( bankXAngle, bankYAngle, 320 ), 0.1f );

        else if (Input.GetAxisRaw("Horizontal") < 0)
            bankingContainer.rotation = Quaternion.Slerp( bankingContainer.rotation, Quaternion.Euler( bankXAngle, bankYAngle, 40 ), 0.1f);

        else
            bankingContainer.rotation = Quaternion.Slerp( bankingContainer.rotation, Quaternion.Euler( bankXAngle, bankYAngle, 0 ), 0.1f);

        // Move the bird forward
        transform.position += transform.forward * movSpeed;

	}
}
