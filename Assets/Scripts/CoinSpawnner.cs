using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnner : MonoBehaviour {

    public GameObject coin;
    // Use this for initialization
    public void CreateCoin ()
    {
        Instantiate(coin, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));
       
    }
	
	
}
