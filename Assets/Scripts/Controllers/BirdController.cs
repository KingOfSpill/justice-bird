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

    public Grid grid;

    // The bird's current position on the grid
    public int gridX;
    public int gridY;

    // This holds the banking container object, which allows us to visually show banking without effecting the whole shapes angle around its z-axis
    public Transform bankingContainer;

    // Use this for initialization
    void Start ()
    {

        setSkin();

        gridX = grid.getXCenter();
        gridY = grid.getYCenter();
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

	    updateRotation(verticalInput, horizontalInput);

        Vector3 targetPosition = grid.gridToWorldPosition(gridX, gridY);

        if( Vector3.Distance( transform.position, targetPosition ) < 1f )
	       updateGridPosition(verticalInput, horizontalInput);

	    updatePosition();

    }

    public void setSkin()
    {
        int curskin = SaveLoad.loadCurrentBirdSkin();

        gameObject.GetComponentInChildren<Renderer>().material = Resources.LoadAll<Material>("BirdSkins")[curskin];
    }

    public void updateRotation(float verticalInput, float horizontalInput)
    {

	    // Convert the user input into the amount of rotation wo want to do
        float vertical = verticalInput * Time.deltaTime * rotSpeed;

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
        bankingContainer.rotation = Quaternion.Slerp( bankingContainer.rotation, Quaternion.Euler( bankXAngle, bankYAngle, mainZAngle - (bankAngle * horizontalInput) ), 0.1f);

    }

    public void updateGridPosition(float verticalInput, float horizontalInput)
    {

	    if( !Mathf.Approximately( horizontalInput, 0.0f ) )
		    gridX += Mathf.RoundToInt( Mathf.Sign( horizontalInput ) );

	    gridX = grid.clampXToGrid( gridX );

	    if( !Mathf.Approximately( verticalInput, 0.0f ) )
		    gridY += Mathf.RoundToInt( Mathf.Sign( verticalInput ) );

	    gridY = grid.clampYToGrid( gridY );
    
    }

    public void updatePosition()
    {

        Vector3 targetPosition = grid.gridToWorldPosition(gridX, gridY);

        transform.position = Vector3.Lerp( transform.position, targetPosition, 0.1f * Time.timeScale) ;

    }

}