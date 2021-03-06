using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopController : MonoBehaviour {

    public int fallSpeed = 2;
    public AudioClip splat;
    private AudioSource source;

	// Use this for initialization
	public void Start ()
    {

        source = this.gameObject.AddComponent<AudioSource>();
        source.clip = splat;
        Destroy(gameObject, 30.0f);

	}
	
	// Update is called once per frame
	public void Update ()
    {

        transform.position -= new Vector3(0, fallSpeed, 0);
		
	}

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("NPC"))
        {

            other.GetComponent<CoinSpawner>().CreateCoin();
            source.Play();
			Destroy (gameObject);
            
        }

	}
    

}
