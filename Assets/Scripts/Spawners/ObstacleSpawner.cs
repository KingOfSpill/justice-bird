using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] spawnableObstacles;
    public List<GameObject> spawnedObstacles;

    public Grid spawnerGrid;

    public int[] continuousSumOfWeights;
    public int totalSumOfWeights;

    // Use this for initialization
    void Start ()
	{
		loadResources("Obstacles");
        calculateWeights();
	}

    // Update is called once per frame
    void Update()
    {

        if (0 == Random.Range(0, 50))
        {

            Quaternion rotOffset = Quaternion.Euler(0, -90, 0);

            spawnedObstacles.Add( spawn(transform.rotation * rotOffset) );

        }

        if (spawnedObstacles.Count > 255)
        {
            Destroy(spawnedObstacles[0], 0.0f);

            spawnedObstacles.RemoveAt(0);
        }

    }

    public void calculateWeights()
    {

        continuousSumOfWeights = new int[spawnableObstacles.Length];
        continuousSumOfWeights[0] = spawnableObstacles[0].GetComponent<ModuleWeightContainer>().weight;

        for (int i = 1; i < spawnableObstacles.Length; i++)
            continuousSumOfWeights[i] = spawnableObstacles[i].GetComponent<ModuleWeightContainer>().weight + continuousSumOfWeights[i - 1];

        totalSumOfWeights = continuousSumOfWeights[continuousSumOfWeights.Length - 1];

    }

    public void deleteObstacle(GameObject obstacle)
    {

        spawnedObstacles.Remove(obstacle);
        Destroy(obstacle, 0.0f);

    }

	void loadResources(string folder)
    {
        spawnableObstacles = Resources.LoadAll<GameObject>(folder);
    }

    public GameObject spawn( Quaternion rotation)
    {

        int randWeighted = Random.Range(0, totalSumOfWeights);
        int randIndex = 0;

        while (continuousSumOfWeights[randIndex] < randWeighted)
            randIndex++;

        GameObject objectToSpawn = spawnableObstacles[randIndex];

        int xAxis = objectToSpawn.GetComponent<SpawnerPositionContainer>().getRandomXForSpawning();
        int yAxis = objectToSpawn.GetComponent<SpawnerPositionContainer>().getRandomYForSpawning();

        Vector3 position = spawnerGrid.gridToWorldPosition(xAxis, yAxis);

        return Instantiate(objectToSpawn, position, rotation);

    }

}
