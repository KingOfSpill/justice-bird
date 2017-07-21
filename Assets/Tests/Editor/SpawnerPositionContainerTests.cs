using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class SpawnerPositionContainerTests {

    [Test]
    public void getRandomXGetsRandomX()
    {

        GameObject spawnable = new GameObject();
        SpawnerPositionContainer container = spawnable.AddComponent<SpawnerPositionContainer>();
        container.xPositions = new int[] { 0, 1, 2 };

        int[] array = new int[20];
        bool isAnElement = true;

        for (int i = 0; i < 20; i++)
        {
            int x = container.getRandomXForSpawning();
            isAnElement = isAnElement && (x < 3 && x >= 0);
        }

        Assert.IsTrue(isAnElement);

    }

    [Test]
    public void getRandomYGetsRandomY()
    {

        GameObject spawnable = new GameObject();
        SpawnerPositionContainer container = spawnable.AddComponent<SpawnerPositionContainer>();
        container.yPositions = new int[] { 0, 1, 2 };

        int[] array = new int[20];
        bool isAnElement = true;

        for (int i = 0; i < 20; i++)
        {
            int y = container.getRandomYForSpawning();
            isAnElement = isAnElement && (y < 3 && y >= 0);
        }

        Assert.IsTrue(isAnElement);

    }

}
