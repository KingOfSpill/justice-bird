﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ModuleSpawnerTests {

	[Test]
	public void calculateWeightsGeneratesProperArray()
    {

        GameObject[] spawnableModules = new GameObject[5];

        for( int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            spawnableModules[i] = spawnableObj;
        }

        int[] expectedContinousSumOfWeights = new int[] { 0, 1, 3, 6, 10 };

        GameObject spawnControllerHolder = new GameObject();
        ModuleSpawner spawner = spawnControllerHolder.AddComponent<ModuleSpawner>();

        spawner.spawnableModules = spawnableModules;

        spawner.calculateWeights();

        Assert.AreEqual(expectedContinousSumOfWeights, spawner.continuousSumOfWeights);

	}

    [Test]
    public void calculateWeightsSumsWeightsProperly()
    {

        GameObject[] spawnableModules = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            spawnableModules[i] = spawnableObj;
        }

        int expectedTotalSumOfWeights = 10;

        GameObject spawnControllerHolder = new GameObject();
        ModuleSpawner spawnController = spawnControllerHolder.AddComponent<ModuleSpawner>();

        spawnController.spawnableModules = spawnableModules;

        spawnController.calculateWeights();

        Assert.AreEqual(expectedTotalSumOfWeights, spawnController.totalSumOfWeights);

    }

    [Test]
    public void spawnRandomModuleSpawnsModule()
    {

        GameObject[] spawnableModules = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            GameObject spawnableObj = new GameObject();
            spawnableObj.AddComponent<ModuleWeightContainer>().weight = i;
            spawnableModules[i] = spawnableObj;
        }

        GameObject spawnControllerHolder = new GameObject();
        ModuleSpawner spawnController = spawnControllerHolder.AddComponent<ModuleSpawner>();

        spawnController.spawnableModules = spawnableModules;
        spawnController.totalSumOfWeights = 10;
        spawnController.continuousSumOfWeights = new int[] { 0, 1, 3, 6, 10 };

        GameObject newModule = spawnController.spawnRandomModule(spawnControllerHolder.transform.position, spawnControllerHolder.transform.rotation);

        Assert.IsNotNull(newModule);

    }

}
