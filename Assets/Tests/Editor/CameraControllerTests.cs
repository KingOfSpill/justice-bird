﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CameraControllerTests {

	[Test]
	public void moveChangesPosition() {

        GameObject camera = new GameObject();
        CameraController cameraController = camera.AddComponent<CameraController>();

        Vector3 position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z); 

        cameraController.move();

        Assert.AreNotEqual(position, camera.transform.position);        
	}

    [Test]
    public void handleTriggerUpdatesRotationAmountRemaining()
    {

        GameObject camera = new GameObject();
        CameraController cameraController = camera.AddComponent<CameraController>();

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trackChangeTrigger = triggerObject.AddComponent<TrackChangeTrigger>();

        float oldRotationAmount = cameraController.rotationAmountRemaining;

        cameraController.handleTrigger(trackChangeTrigger);

        Assert.AreNotEqual(oldRotationAmount, cameraController.rotationAmountRemaining);

    }

    [Test]
    public void handleTriggerUpdatesRotationCenter()
    {

        GameObject camera = new GameObject();
        CameraController cameraController = camera.AddComponent<CameraController>();

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trackChangeTrigger = triggerObject.AddComponent<TrackChangeTrigger>();

        camera.transform.position = new Vector3(100, 100, 100);

        Vector3 oldRotationCenter = cameraController.rotationCenter;

        cameraController.handleTrigger(trackChangeTrigger);

        Assert.AreNotEqual(oldRotationCenter, cameraController.rotationCenter);

    }

    [Test]
    public void handleTriggerUpdatesRotationAxis()
    {

        GameObject camera = new GameObject();
        CameraController cameraController = camera.AddComponent<CameraController>();

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trackChangeTrigger = triggerObject.AddComponent<TrackChangeTrigger>();

        Vector3 oldRotationAxis = cameraController.rotationAxis;

        cameraController.handleTrigger(trackChangeTrigger);

        Assert.AreNotEqual(oldRotationAxis, cameraController.rotationAxis);

    }

    [Test]
    public void handleTriggerUpdatesRotationSpeedProperly()
    {

        GameObject camera = new GameObject();
        CameraController cameraController = camera.AddComponent<CameraController>();

        GameObject triggerObject = new GameObject();
        TrackChangeTrigger trackChangeTrigger = triggerObject.AddComponent<TrackChangeTrigger>();

        camera.transform.position = new Vector3(10f, 0f, 0f);

        float expectedRotationSpeed = 11.4591559026164f;

        cameraController.handleTrigger(trackChangeTrigger);

        Assert.IsTrue(  Mathf.Approximately(expectedRotationSpeed, cameraController.rotationSpeed) );

    }

}
