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

    // Stores the percent of the screen that should be off-limits
    public float screenMargin = 0.0f;

    // The size of the grid the bird lives on
    public int gridHeight = 3;
    public int gridWidth = 3;

    // The bird's current position on the grid
    public int gridX;
    public int gridY;
    private float horizontalTarget;
    private float verticalTarget;

    private float unitWidth;
    private float unitHeight;

    // The bird's current speed
    private float curSpeed;

    // This holds the banking container object, which allows us to visually show banking without effecting the whole shapes angle around its z-axis
    public Transform bankingContainer;

    // Use this for initialization
    void Start () {

        curSpeed = movSpeed;

        unitWidth = (1.0f - ( 2.0f * screenMargin ))/(gridWidth);
        unitHeight = (1.0f - ( 2.0f * screenMargin ))/(gridHeight);

        gridX = 0;
        gridY = 0;
		
	}

    // Update is called once per frame
    void Update() {

    	updateRotation();

    	updateTargetPosition();

    	updatePosition();

    }

    void updateRotation() {

    	// Convert the user input into the amount of rotation wo want to do
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

    }

    void updateTargetPosition(){

    	Vector3 viewPortPos = Camera.main.WorldToViewportPoint(transform.position);

    	if( Vector3.Distance( transform.position, Camera.main.ViewportToWorldPoint(new Vector3( horizontalTarget, verticalTarget, viewPortPos.z ) ) ) < 1f ){

    		if( !Mathf.Approximately( Input.GetAxis("Horizontal"), 0.0f ) )
				gridX += Mathf.RoundToInt( Mathf.Sign( Input.GetAxis("Horizontal") ) );

    		gridX = Mathf.Clamp(gridX, -(gridWidth/2), (gridWidth/2) );

    		if( !Mathf.Approximately( Input.GetAxis("Vertical"), 0.0f ) )
    			gridY += Mathf.RoundToInt( Mathf.Sign( Input.GetAxis("Vertical") ) );

    		gridY = Mathf.Clamp(gridY, -(gridWidth/2), (gridWidth/2) );

    		horizontalTarget =  0.5f + (gridX * unitWidth);
    		verticalTarget =  0.5f + (gridY * unitHeight);

    	}

    }

    void updatePosition() {

    	Vector3 viewPortPos = Camera.main.WorldToViewportPoint(transform.position);

        transform.position = Vector3.Lerp( transform.position, Camera.main.ViewportToWorldPoint(new Vector3( horizontalTarget, verticalTarget, viewPortPos.z ) ), 0.1f) ;

    }

	// Food trigger
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Food")) {

			other.gameObject.SetActive (false);

		}

	}
}
