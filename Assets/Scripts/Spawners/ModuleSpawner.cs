using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawner : MonoBehaviour {

    public GameObject[] spawnableModules;
    public List<GameObject> spawnedModules;

    public int[] continuousSumOfWeights;
    public int totalSumOfWeights;

    // Use this for initialization
    void Start ()
    {

        loadResources("Tiles");
        calculateWeights();
        spawnedModules[0].GetComponent<BuildingSpawner>().spawnBuildings();

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (spawnedModules.Count > 3)
        {

            Destroy(spawnedModules[0], 0.0f);

            spawnedModules.RemoveAt(0);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        // If we hit a module end, we want to spawn a new module
        if (other.CompareTag("ModuleEndNode"))
                spawnedModules.Add(spawnModule(other.transform.position, transform.rotation));

    }

    void loadResources(string folder)
    {
        spawnableModules = Resources.LoadAll<GameObject>(folder);
    }

    public void calculateWeights()
    {
        continuousSumOfWeights = new int[spawnableModules.Length];

        continuousSumOfWeights[0] = spawnableModules[0].GetComponent<ModuleWeightContainer>().weight;

        for ( int i = 1; i < spawnableModules.Length; i++)
            continuousSumOfWeights[i] = spawnableModules[i].GetComponent<ModuleWeightContainer>().weight + continuousSumOfWeights[i-1];

        totalSumOfWeights = continuousSumOfWeights[continuousSumOfWeights.Length-1];
    }

    public GameObject spawnModule(Vector3 position, Quaternion rotation)
    {

        GameObject newModule = spawnRandomModule(position, rotation);

        newModule.GetComponent<BuildingSpawner>().spawnBuildings();

        return newModule;

    }

    public GameObject spawnRandomModule( Vector3 position, Quaternion rotation)
    {
        int randWeighted = Random.Range(0, totalSumOfWeights+1);

        int randIndex = 0;

        while (continuousSumOfWeights[randIndex] < randWeighted)
            randIndex++;

        return Instantiate(spawnableModules[randIndex], position, rotation);

    }

}
