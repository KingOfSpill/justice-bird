using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TrackChangeTriggerTests {

	[Test]
	public void getRotationCenterReturnsCorrectlyFor90Degrees() {

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trigger = triggerObject.AddComponent<TrackChangeTrigger>();

        trigger.rotationAmount = 90.0f;
        trigger.transform.position = Vector3.zero;

        Vector3 inPosition = new Vector3(10f,0f,0f);

        Vector3 expectedCenter = new Vector3(10f, 0f, 10f);

        Vector3 rotationCenter = trigger.getRotationCenter(inPosition);

        Assert.Greater(0.001f, Vector3.Distance(expectedCenter, rotationCenter) );

	}

    [Test]
    public void getOutPositionReturnsCorrectlyFor90Degrees()
    {

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trigger = triggerObject.AddComponent<TrackChangeTrigger>();

        trigger.rotationAmount = 90.0f;
        trigger.transform.position = Vector3.zero;

        Vector3 inPosition = new Vector3(10f, 0f, 0f);

        Vector3 expectedPosition = new Vector3(0f, 0f, 10f);

        Vector3 outPosition = trigger.getOutPosition(inPosition);

        Assert.Greater(0.001f, Vector3.Distance(expectedPosition, outPosition));

    }

}
