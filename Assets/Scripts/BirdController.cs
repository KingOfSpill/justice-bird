using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    // Variables for movement/rotation speed and for preset angles
    public float movSpeed = 2;
    public float rotSpeed = 60;
    public float maxVerticalAngle = 30;
    public float maxHorizontalAngle = 30;
    public float bankAngle = 40;
    public float screenMargin = 0.1f;

    private float curSpeed;

    // This holds the banking container object, which allows us to visually show banking without effecting the whole shapes angle around its z-axis
    public Transform bankingContainer;

    // Use this for initialization
    void Start () {

        curSpeed = movSpeed;

	}

    // Update is called once per frame
    void Update() {

        // Convert the user input into the amount of rotation wo want to do
        float verticalMov = Input.GetAxis("Vertical") * Time.deltaTime * movSpeed;
        float horizontalMov = Input.GetAxis("Horizontal") * Time.deltaTime * movSpeed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * rotSpeed;
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;

        // Perform rotations
        transform.Rotate(new Vector3(-vertical, 0, 0));

        // Let's store these values to make the code below more readable
        float mainXAngle = transform.eulerAngles.x;
        float mainYAngle = transform.eulerAngles.y;
        float mainZAngle = transform.eulerAngles.z;

        // Clamping the rotation keeps the bird from flying too steeply
        if( mainXAngle > maxVerticalAngle && mainXAngle < 180 )
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler( maxVerticalAngle - Camera.main.transform.rotation.x, mainYAngle, mainZAngle ), 0.1f);

        if (mainXAngle < 360 - maxVerticalAngle && mainXAngle >= 180)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler( 360 - maxVerticalAngle - Camera.main.transform.rotation.x, mainYAngle, mainZAngle), 0.1f);

        // Let's store these values to make the code below more readable
        float bankXAngle = bankingContainer.eulerAngles.x;
        float bankYAngle = bankingContainer.eulerAngles.y;

        // We want to bank to preset angles depending on the input we are receiving on the horizontal axis right now
        bankingContainer.rotation = Quaternion.Slerp( bankingContainer.rotation, Quaternion.Euler( bankXAngle, bankYAngle, mainZAngle - (bankAngle * Input.GetAxis("Horizontal")) ), 0.1f);

        transform.localPosition = transform.localPosition + new Vector3( horizontalMov, verticalMov, 0 );

        // This will keep the bird on-screen
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
        position.x = Mathf.Clamp(position.x, 0.0f + screenMargin, 1.0f - screenMargin );
        position.y = Mathf.Clamp(position.y, 0.0f + screenMargin, 1.0f - screenMargin);
        transform.position = Camera.main.ViewportToWorldPoint(position);

    }

	// Food trigger
	void OnTriggerEnter(Collider other){

		AudioSource aud = GetComponent<AudioSource>();

		if (other.gameObject.CompareTag ("Food")) {

			other.gameObject.SetActive (false);
			aud.Play ();

		}

	}
}
