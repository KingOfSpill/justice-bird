﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ObstacleSpawnerTests {

    [Test]
    public void calculateWeightsGeneratesProperArray()
    {

        GameObject[] spawnableObstacles = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            spawnableObstacles[i] = spawnableObj;
        }

        int[] expectedContinousSumOfWeights = new int[] { 0, 1, 3, 6, 10 };

        GameObject spawnControllerHolder = new GameObject();
        ModuleSpawner spawner = spawnControllerHolder.AddComponent<ModuleSpawner>();

        spawner.spawnableModules = spawnableObstacles;

        spawner.calculateWeights();

        Assert.AreEqual(expectedContinousSumOfWeights, spawner.continuousSumOfWeights);

    }

    [Test]
    public void calculateWeightsSumsWeightsProperly()
    {

        GameObject[] spawnableObstacles = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            spawnableObstacles[i] = spawnableObj;
        }

        int expectedTotalSumOfWeights = 10;

        GameObject spawnControllerHolder = new GameObject();
        ObstacleSpawner spawnController = spawnControllerHolder.AddComponent<ObstacleSpawner>();

        spawnController.spawnableObstacles = spawnableObstacles;

        spawnController.calculateWeights();

        Assert.AreEqual(expectedTotalSumOfWeights, spawnController.totalSumOfWeights);

    }

    [Test]
    public void spawnSpawnsObstacle()
    {

        GameObject[] spawnableObstacles = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            SpawnerPositionContainer container = spawnableObj.AddComponent<SpawnerPositionContainer>();
            container.xPositions = new int[] { 0 };
            container.yPositions = new int[] { 0 };
            spawnableObstacles[i] = spawnableObj;
        }

        GameObject spawnControllerHolder = new GameObject();
        ObstacleSpawner spawnController = spawnControllerHolder.AddComponent<ObstacleSpawner>();

        spawnController.spawnableObstacles = spawnableObstacles;
        spawnController.totalSumOfWeights = 10;
        spawnController.continuousSumOfWeights = new int[] { 0, 1, 3, 6, 10 };

        GameObject gridObject = new GameObject();
        Camera gridCamera = spawnControllerHolder.AddComponent<Camera>();
        Grid grid = spawnControllerHolder.AddComponent<Grid>();
        grid.gridObject = gridObject;
        grid.gridCamera = gridCamera;

        grid.Start();

        spawnController.spawnerGrid = grid;

        GameObject newObstacle = spawnController.spawn(spawnControllerHolder.transform.rotation);

        Assert.IsNotNull(newObstacle);

    }
}
