﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class BirdCustomizationLoaderTests {

	[Test]
	public void spawnItemsSpawnsItems() {

        GameObject customizationLoaderObject = new GameObject();
        BirdCustomizationLoader loader = customizationLoaderObject.AddComponent<BirdCustomizationLoader>();
        loader.materials = new Material[] { new Material(Shader.Find("Diffuse"))};
        loader.unlocked = new System.Collections.Generic.List<bool> { true };

        GameObject customizationOption = new GameObject();
        customizationOption.AddComponent<RectTransform>();
        customizationOption.AddComponent<Button>();
        GameObject renderHolder = new GameObject();
        renderHolder.AddComponent<MeshRenderer>();
        renderHolder.transform.SetParent(customizationOption.transform);

        loader.customizationOption = customizationOption;
        loader.spawned = new System.Collections.Generic.List<GameObject>();

        loader.spawnItems();

        Assert.Less(0, loader.spawned.Count);

	}

}
