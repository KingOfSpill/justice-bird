using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRotator : MonoBehaviour {

	public float rotationSpeed = 1.5f; 
	int x = 30, y = -30, z = 30;

	public void Update ()
    {
		transform.Rotate (new Vector3 (rotationSpeed * x, rotationSpeed * y, rotationSpeed * z) * Time.deltaTime);
	}

}
