using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PoopSpawnerTests {

	
	[UnityTest]
	public IEnumerator spawnPoopSpawnsPoop() {

        GameObject fakeBird = new GameObject();

        PoopSpawner spawner = fakeBird.AddComponent<PoopSpawner>();
        UIscript ui = fakeBird.AddComponent<UIscript>();
        UnityEngine.UI.Image img = fakeBird.AddComponent<UnityEngine.UI.Image>();

        ui.poopFill = img;
        ui.poopFill.enabled = true;
        ui.pooAmount = 1;

        GameObject poop = new GameObject();
        poop.AddComponent<PoopController>();

        spawner.Poop = poop;
        spawner.ui = ui;

        GameObject newPoop = spawner.spawnPoop();

        Assert.IsNotNull(newPoop);       

		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}

    [UnityTest]
    public IEnumerator spawnPoopDoesntSpawnPoopIfPoopBarIsEmpty()
    {

        GameObject fakeBird = new GameObject();

        PoopSpawner spawner = fakeBird.AddComponent<PoopSpawner>();
        UIscript ui = fakeBird.AddComponent<UIscript>();
        UnityEngine.UI.Image img = fakeBird.AddComponent<UnityEngine.UI.Image>();

        ui.poopFill = img;
        ui.poopFill.enabled = false;
        ui.pooAmount = 0;

        GameObject poop = new GameObject();
        poop.AddComponent<PoopController>();

        spawner.Poop = poop;
        spawner.ui = ui;

        GameObject newPoop = spawner.spawnPoop();

        Assert.IsNull(newPoop);

        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
