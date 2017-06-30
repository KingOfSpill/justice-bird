using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour {

	public GameObject[] spawnableModules;
    public List<GameObject> spawnedModules;

    public Grid spawnerGrid;

	// Use this for initialization
	void Start ()
	{
		loadResources("NPCs");
	}

    // Update is called once per frame
    void Update()
    {

        if (0 == Random.Range(0, 50))
        {

            int xAxis = Random.Range(0, spawnerGrid.gridWidth);

            Vector3 offset = new Vector3(0, 0, 0);

            Quaternion rotOffset = Quaternion.Euler(0, -90, 0);

            spawnedModules.Add( spawn(spawnerGrid.gridToWorldPosition(xAxis, 0) + offset, transform.rotation * rotOffset) );

        }

        if (spawnedModules.Count > 30)
        {
            Destroy(spawnedModules[0], 0.0f);

            spawnedModules.RemoveAt(0);
        }

    }

    public void deleteNPC(GameObject NPC)
    {

        spawnedModules.Remove(NPC);
        Destroy(NPC, 0.0f);

    }

	void loadResources(string folder)
    {
        spawnableModules = Resources.LoadAll<GameObject>(folder);
    }

    public GameObject spawn( Vector3 position, Quaternion rotation)
    {
        int randIndex = Random.Range(0, spawnableModules.Length);

        return Instantiate(spawnableModules[randIndex], position, rotation);
    }

}
