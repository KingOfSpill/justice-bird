using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public int rotationSpeed = 1; 
	int x = 30, y = -30, z = 30;

	void Update () {

		transform.Rotate (new Vector3 (rotationSpeed * x, rotationSpeed * y, rotationSpeed * z) * Time.deltaTime);
	}
}
