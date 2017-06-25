using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackChangeTrigger : MonoBehaviour {

    public float rotationAmount = 0.0f;
    public Vector3 rotationAxis = Vector3.up;

    public Vector3 getRotationCenter( Vector3 inPosition )
    {

        Vector3 outPosition = getOutPosition(inPosition);

        // If the turn is 90 degrees exactly, then we can't use the regular method to find the center of the rotation
        // But it means that it's the 4th corner of the square made by inPosition, outPosition, and transform.position
        // So we just find that corner and return it
        if(approximately( Mathf.Abs(rotationAmount), 90.0f ))
        {

            if (approximately(inPosition.x, transform.position.x))
                return new Vector3(outPosition.x, inPosition.y, inPosition.z);

            if (approximately(inPosition.z, transform.position.z))
                return new Vector3(inPosition.x, inPosition.y, outPosition.z);

        }

        // This next part of code is based on z = mx + b (The line equation)

        // This gets the slope of the line from the point we're starting at to the center of the rotation
        float inM = (transform.position.x - inPosition.x) / (inPosition.z - transform.position.z);
        // This gets the slope of the line from the point we want to end up at to the centor of the rotation
        float outM = (outPosition.x - transform.position.x)/(transform.position.z - outPosition.z);

        // This gets the z-intercept for each line
        float inB = (inM * -1f * inPosition.x) + inPosition.z;
        float outB = (outM * -1f * transform.position.x) + transform.position.z;

        //This finds the intersection of the two lines, giving us the centor of the rotation
        float centerX = (inB - outB) / (outM - inM);
        float centerZ = (outM * centerX) + outB;

        return new Vector3(centerX, inPosition.y, centerZ);

    }
    
    public Vector3 getOutPosition( Vector3 inPosition)
    {

        Vector3 direction = inPosition - transform.position;

        // If the angle isn't acute, we need to negate it for this quaternion based rotation to work
        float actualRotation = (rotationAmount >= 90f || rotationAmount <= -90f ? -1 : 1);

        direction = Quaternion.Euler(rotationAxis * (rotationAmount * actualRotation)) * direction;

        Vector3 outPosition = direction + transform.position;

        return outPosition;

    }

    private bool approximately(float x, float y)
    {
        return Mathf.Abs(x - y) < 1f;
    }

}
