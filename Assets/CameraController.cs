using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float movSpeed = 2;
    public float rotChange = 0;
    public float rotSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        // Doing this to keep the  camera level to the ground
        // Camera.main.transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, 0);

        Vector3 forwardFlat = new Vector3(transform.forward.x, 0, transform.forward.z);

        // If there is a change queued up
        if (!Mathf.Approximately(rotChange, 0.0f))
        {

            float toChange = rotSpeed * Mathf.Sign(rotChange);
   
            // Rotate and update the queued rotation
            transform.RotateAround(transform.position, Vector3.up, toChange );
            rotChange -= toChange;

        }

        // This moves us forward constantly
        transform.position += forwardFlat * movSpeed;

    }

    void OnTriggerEnter(Collider other)
    {

        // If we hit a track change, we want to queue a rotation
        if( other.CompareTag("TrackChange") )
        {

            // Here we get the component and check if it actually has it before getting data from it
            TrackChangeTrigger trigger = other.GetComponent<TrackChangeTrigger>();

            if (trigger != null)
                rotChange = trigger.directionChange;

        }

    }

}
