using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawnController : MonoBehaviour {

    public GameObject[] spawnableModules;
    public List<GameObject> spawnedModules;

    public int[] continuousSumOfWeights;
    public int totalSumOfWeights;

    // Use this for initialization
    void Start () {

        spawnableModules = Resources.LoadAll<GameObject>("Tiles");

        continuousSumOfWeights = new int[spawnableModules.Length];

        continuousSumOfWeights[0] = spawnableModules[0].GetComponent<ModuleWeightContainer>().weight;

        for ( int i = 1; i < spawnableModules.Length; i++)
            continuousSumOfWeights[i] = spawnableModules[i].GetComponent<ModuleWeightContainer>().weight + continuousSumOfWeights[i-1];

        totalSumOfWeights = continuousSumOfWeights[continuousSumOfWeights.Length-1];

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

                spawnModule(other.transform.position, nextModuleRotation);

            }

        }

    }

    void spawnModule( Vector3 position, Quaternion rotation)
    {

        int randWeighted = Random.Range(0, totalSumOfWeights);

        int randIndex = 0;

        while (continuousSumOfWeights[randIndex] < randWeighted)
            randIndex++;

        spawnedModules.Add(Instantiate(spawnableModules[randIndex], position, rotation));

    }

}
