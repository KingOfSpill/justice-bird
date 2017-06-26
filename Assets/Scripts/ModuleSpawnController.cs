using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawnController : MonoBehaviour {

    public GameObject[] spawnableModules;
    public List<GameObject> spawnedModules;

    // Use this for initialization
    void Start () {

        spawnableModules = Resources.LoadAll<GameObject>("Tiles");

    }
	
	// Update is called once per frame
	void Update () {

        if (spawnedModules.Count > 3)
        {

            Destroy(spawnedModules[0], 0.0f);

            spawnedModules.RemoveAt(0);

        }

    }

    void OnTriggerEnter(Collider other)
    {

        // If we hit a track change, we want to queue a rotation
        if (other.CompareTag("TrackChange"))
        {

            // Here we get the component and check if it actually has it before getting data from it
            TrackChangeTrigger trigger = other.GetComponent<TrackChangeTrigger>();

            if (trigger != null)
            {

                Quaternion nextModuleRotation =  transform.rotation *  Quaternion.Euler( trigger.rotationAxis * trigger.rotationAmount );

                int randIndex = Random.Range(0, spawnableModules.Length);

                spawnedModules.Add( Instantiate(spawnableModules[randIndex], other.transform.position, nextModuleRotation) );

            }

        }

    }

}
