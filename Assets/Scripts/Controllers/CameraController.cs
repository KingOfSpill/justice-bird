using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float movSpeed = 2;

    public float rotationSpeed = 0;
    public float rotationAmountRemaining = 0;
    public Vector3 rotationCenter;
    public Vector3 rotationAxis;

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        Vector3 forwardFlat = new Vector3(transform.forward.x, 0, transform.forward.z);

        // If there is a change queued up
        if (!Mathf.Approximately(rotationAmountRemaining, 0.0f))
        {
            // Rotate and update the queued rotation
            if (Mathf.Abs(rotationAmountRemaining) >= Mathf.Abs(rotationSpeed))
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
                handleTrigger(trigger);

        }

    }

    public void handleTrigger(TrackChangeTrigger trigger)
    {

        rotationAmountRemaining = trigger.rotationAmount;
        rotationCenter = trigger.getRotationCenter(transform.position);
        rotationAxis = trigger.rotationAxis;

        rotationSpeed = Mathf.Sign(rotationAmountRemaining) * (movSpeed * 360) / (2 * Mathf.PI * Vector3.Distance(transform.position, rotationCenter));

    }

}
