using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ObstacleSpawnerTests {

    [Test]
    public void spawnSpawnsNPC()
    {

        GameObject[] spawnableModules = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableModules[i] = spawnableObj;
        }

        GameObject spawnerHolder = new GameObject();
        ObstacleSpawner spawnController = spawnerHolder.AddComponent<ObstacleSpawner>();

        spawnController.spawnableObstacles = spawnableModules;

        GameObject newNPC = spawnController.spawn( spawnerHolder.transform.rotation);

        Assert.IsNotNull(newNPC);

    }
}
