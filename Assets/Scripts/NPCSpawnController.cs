using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawnController : MonoBehaviour {

	public GameObject[] spawnableModules;
    public List<GameObject> spawnedModules;

    public int[] continuousSumOfWeights;
    public int totalSumOfWeights;

    public Grid spawnerGrid;

	// Use this for initialization
	void Start ()
	{
		loadResources("NPCs");
		calculateWeights();
	}

    // Update is called once per frame
    void Update()
    {

        if (0 == Random.Range(0, 50))
        {

            int xAxis = Random.Range(0, spawnerGrid.gridWidth);

            Vector3 offset = new Vector3(0, 0, 0);

            Quaternion rotOffset = Quaternion.Euler(0, -90, 0);

            spawn(spawnerGrid.gridToWorldPosition(xAxis, 0) + offset, transform.rotation * rotOffset);

        }

        if (spawnedModules.Count > 30)
        {
            Destroy(spawnedModules[0], 0.0f);

            spawnedModules.RemoveAt(0);
        }

    }

    public void deleteNPC(GameObject NPC)
    {

        spawnedModules.Remove(NPC);
        Destroy(NPC, 0.0f);

    }

	void loadResources(string folder)
    {
        spawnableModules = Resources.LoadAll<GameObject>(folder);
    }

    void calculateWeights()
    {
        continuousSumOfWeights = new int[spawnableModules.Length];

        continuousSumOfWeights[0] = spawnableModules[0].GetComponent<ModuleWeightContainer>().weight;

        for ( int i = 1; i < spawnableModules.Length; i++)
            continuousSumOfWeights[i] = spawnableModules[i].GetComponent<ModuleWeightContainer>().weight + continuousSumOfWeights[i-1];

        totalSumOfWeights = continuousSumOfWeights[continuousSumOfWeights.Length-1];
    }

    void spawn( Vector3 position, Quaternion rotation)
    {
        int randWeighted = Random.Range(0, totalSumOfWeights);

        int randIndex = 0;

        while (continuousSumOfWeights[randIndex] < randWeighted)
            randIndex++;

        spawnedModules.Add(Instantiate(spawnableModules[randIndex], position, rotation));
    }

}
