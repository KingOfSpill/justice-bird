using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float movSpeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Doing this to keep the  camera level to the ground
        // Camera.main.transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, 0);

        Vector3 forwardFlat = new Vector3( transform.forward.x, 0, transform.forward.z );

        transform.position += forwardFlat * movSpeed;

    }
}
