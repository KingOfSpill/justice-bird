using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class FoodSpawnerTests {

    [Test]
    public void spawnSpawnsFood()
    {

        GameObject foodSpawnerContainer = new GameObject();

        FoodSpawner spawner = foodSpawnerContainer.AddComponent<FoodSpawner>();

        GameObject food = new GameObject();

        spawner.food = food;

        GameObject newFood = spawner.spawn(foodSpawnerContainer.transform.position,foodSpawnerContainer.transform.rotation);

        Assert.IsNotNull(newFood);

    }
}
