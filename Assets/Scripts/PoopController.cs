using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopController : MonoBehaviour {

    public int fallSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position -= new Vector3(0, fallSpeed, 0);
		
	}

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("NPC"))
        {
            other.GetComponent<CoinSpawnner>().CreateCoin();
        }
    }

}
