using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BuildingSpawnerTests {

    [Test]
    public void spawnBuildingsSpawnsBuildings()
    {

        GameObject[] spawnablePositions = new GameObject[1];
        spawnablePositions[0] = new GameObject();

        GameObject spawnerObject = new GameObject();
        BuildingSpawner spawner = spawnerObject.AddComponent<BuildingSpawner>();

        spawner.spawnPositions = spawnablePositions;

        int children = spawnerObject.transform.childCount;

        spawner.spawnBuildings();

        Assert.Less(children, spawnerObject.transform.childCount);

    }

}
