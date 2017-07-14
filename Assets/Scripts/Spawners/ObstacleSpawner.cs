using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] spawnableObstacles;
    public List<GameObject> spawnedObstacles;

    public Grid spawnerGrid;

	// Use this for initialization
	void Start ()
	{
		loadResources("Obstacles");
	}

    // Update is called once per frame
    void Update()
    {

        if (0 == Random.Range(0, 50))
        {

            int xAxis = Random.Range(0, spawnerGrid.gridWidth);

            Vector3 offset = new Vector3(0, 0, 0);

            Quaternion rotOffset = Quaternion.Euler(0, -90, 0);

            spawnedObstacles.Add( spawn(transform.rotation * rotOffset) );

        }

        if (spawnedObstacles.Count > 255)
        {
            Destroy(spawnedObstacles[0], 0.0f);

            spawnedObstacles.RemoveAt(0);
        }

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
        int randIndex = Random.Range(0, spawnableObstacles.Length);

        GameObject objectToSpawn = spawnableObstacles[randIndex];

        int xAxis = objectToSpawn.GetComponent<SpawnerPositionContainer>().getRandomXForSpawning();
        int yAxis = objectToSpawn.GetComponent<SpawnerPositionContainer>().getRandomYForSpawning();

        Vector3 position = spawnerGrid.gridToWorldPosition(xAxis, yAxis);

        return Instantiate(objectToSpawn, position, rotation);
    }

}
