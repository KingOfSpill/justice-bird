using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour {

    public GameObject[] spawnableBuildings;
    public GameObject[] spawnPositions;

    public void spawnBuildings ()
    {

        loadResources("Buildings");

        foreach (GameObject obj in spawnPositions)
        {
            spawn(obj.transform.position, obj.transform.rotation);
        }

    }

    void loadResources(string folder)
    {
        spawnableBuildings = Resources.LoadAll<GameObject>(folder);
    }

    void spawn(Vector3 position, Quaternion rotation)
    {
        int randIndex = Random.Range(0, spawnableBuildings.Length);

        Instantiate(spawnableBuildings[randIndex], position, rotation, transform);
    }

}
