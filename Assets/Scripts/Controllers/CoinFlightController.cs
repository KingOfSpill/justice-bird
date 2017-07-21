using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlightController : MonoBehaviour {

    public GameObject bird;

    public void Start()
    {

        bird = GameObject.Find("/Main Camera/Bird");
        transform.SetParent(bird.transform.parent, true);

    }

	public void Update()
    {

        transform.position = Vector3.Lerp( transform.position, bird.transform.position, 0.1f * Time.timeScale) ;

	}
}