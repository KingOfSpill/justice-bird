using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PoopSpawnerTests {

	
	[Test]
	public void spawnPoopSpawnsPoop() {

        GameObject fakeBird = new GameObject();

        PoopSpawner spawner = fakeBird.AddComponent<PoopSpawner>();
        UIscript ui = fakeBird.AddComponent<UIscript>();
        UnityEngine.UI.Image img = fakeBird.AddComponent<UnityEngine.UI.Image>();

        ui.poopFill = img;
        ui.poopFill.enabled = true;
        ui.pooAmount = 1;

        spawner.ui = ui;
        spawner.Start();

        GameObject newPoop = spawner.spawnPoop();

        Assert.IsNotNull(newPoop);
	}

    [Test]
    public void spawnPoopDoesntSpawnPoopIfPoopBarIsEmpty()
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

        spawner.poop = poop;
        spawner.ui = ui;

        GameObject newPoop = spawner.spawnPoop();

        Assert.IsNull(newPoop);
    }
}
