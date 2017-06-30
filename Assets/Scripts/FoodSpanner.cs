using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpanner : MonoBehaviour {
	public GameObject food;
	public float delay = 3.0f;
	public bool active = true;
	public Grid spawnerGrid;

	void Start () {
		StartCoroutine (CoinGenerator ());
	}

	IEnumerator CoinGenerator(){
		yield return new WaitForSeconds (delay);

		if (active) {
			GameObject bread = (GameObject)Instantiate (food, spawnerGrid.gridToWorldPosition(Random.Range(0,spawnerGrid.gridWidth), Random.Range(0,spawnerGrid.gridWidth))
					+ (spawnerGrid.gridToForwardAxis (1, 1) * 5), Quaternion.identity);

			Destroy (bread, 30.0f);
		}

		StartCoroutine (CoinGenerator ());
	}
		
}