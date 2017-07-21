using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollector : MonoBehaviour {

	public UIscript ui;

	void OnTriggerEnter(Collider other)
    {

		if (other.gameObject.CompareTag ("Food"))
        {

            DestroyFood(other.gameObject);
			Destroy(other.gameObject);

		}
	}

    public void DestroyFood(GameObject other)
    {

        AudioSource pickUp = GetComponent<AudioSource>();
        pickUp.Play();

        other.SetActive(false);
        ui.foodCollected();

    }

}