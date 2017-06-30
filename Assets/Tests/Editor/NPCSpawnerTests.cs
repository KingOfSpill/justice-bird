using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NPCSpawnerTests {

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
        NPCSpawner spawnController = spawnerHolder.AddComponent<NPCSpawner>();

        spawnController.spawnableModules = spawnableModules;

        GameObject newNPC = spawnController.spawn(spawnerHolder.transform.position, spawnerHolder.transform.rotation);

        Assert.IsNotNull(newNPC);

    }
}
