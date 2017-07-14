using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {
	public GameObject food;
	public float delay = 3.0f;
	public bool active = true;
	public Grid spawnerGrid;

	void Start () {
		StartCoroutine (FoodGenerator ());
	}

	IEnumerator FoodGenerator(){
		yield return new WaitForSeconds (delay);

		if (active) {

            int randX = Random.Range(0, spawnerGrid.gridWidth);
            int randY = Random.Range(0, spawnerGrid.gridWidth);

            for (int i = 0; i < 5; i++)
            {
                GameObject bread = spawn(spawnerGrid.gridToWorldPosition(randX, randY), Quaternion.identity);
                yield return new WaitForSeconds(0.2f);
                Destroy(bread, 30.0f);
            }
		}

		StartCoroutine (FoodGenerator ());

	}

    public GameObject spawn( Vector3 position, Quaternion rotation)
    {
        return Instantiate(food, position, rotation);
    }
		
}