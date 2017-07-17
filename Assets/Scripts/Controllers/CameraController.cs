using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float movSpeed = 2;

    private float rotationSpeed = 0;
    private float rotationAmountRemaining = 0;
    private Vector3 rotationCenter;
    private Vector3 rotationAxis;

    // Update is called once per frame
    void Update()
    {

        // Doing this to keep the  camera level to the ground
        // Camera.main.transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, 0);

        Vector3 forwardFlat = new Vector3(transform.forward.x, 0, transform.forward.z);

        // If there is a change queued up
        if (!Mathf.Approximately(rotationAmountRemaining, 0.0f))
        {
            // Rotate and update the queued rotation
            if ( Mathf.Abs(rotationAmountRemaining) >= Mathf.Abs(rotationSpeed))
            {
                transform.RotateAround(rotationCenter, rotationAxis, rotationSpeed * Time.timeScale);
                rotationAmountRemaining -= rotationSpeed * Time.timeScale;
            }
            else
            {
                transform.RotateAround(rotationCenter, rotationAxis, rotationAmountRemaining * Time.timeScale);
                rotationAmountRemaining -= rotationAmountRemaining * Time.timeScale;
            }

        }
        else
        {
            // This moves us forward constantly
            transform.position += forwardFlat * movSpeed * Time.timeScale;
        }

        

    }

    void OnTriggerEnter(Collider other)
    {

        // If we hit a track change, we want to queue a rotation
        if( other.CompareTag("TrackChange") )
        {

            // Here we get the component and check if it actually has it before getting data from it
            TrackChangeTrigger trigger = other.GetComponent<TrackChangeTrigger>();

            if (trigger != null)
            {

                rotationAmountRemaining = trigger.rotationAmount;
                rotationCenter = trigger.getRotationCenter(transform.position);
                rotationAxis = trigger.rotationAxis;

                rotationSpeed = Mathf.Sign(rotationAmountRemaining) * (movSpeed * 360) / (2 * Mathf.PI * Vector3.Distance(transform.position, rotationCenter));

            }

        }

    }

}
