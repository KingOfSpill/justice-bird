using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPositionContainer : MonoBehaviour {

    public int[] xPositions;
    public int[] yPositions;

    public int getRandomXForSpawning()
    {

        int randX = Random.Range(0, xPositions.Length);

        return xPositions[randX];

    }

    public int getRandomYForSpawning()
    {

        int randY = Random.Range(0, yPositions.Length);

        return yPositions[randY];

    }

}
