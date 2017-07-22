using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class PoopCustomizationLoaderTests {

    [Test]
    public void spawnItemsSpawnsItems()
    {

        GameObject customizationLoaderObject = new GameObject();
        PoopCustomizationLoader loader = customizationLoaderObject.AddComponent<PoopCustomizationLoader>();

        GameObject poop = new GameObject();
        poop.AddComponent<PoopController>();

        loader.prefabs = new GameObject[] { poop };
        loader.unlocked = new System.Collections.Generic.List<bool> { true };

        GameObject customizationOption = new GameObject();
        customizationOption.AddComponent<RectTransform>();
        customizationOption.AddComponent<Button>();

        GameObject custChild = new GameObject();
        custChild.transform.parent = customizationOption.transform;

        GameObject renderHolder = new GameObject();
        renderHolder.AddComponent<MeshRenderer>();
        renderHolder.transform.SetParent(customizationOption.transform);

        loader.customizationOption = customizationOption;
        loader.spawned = new System.Collections.Generic.List<GameObject>();

        loader.spawnItems();

        Assert.Less(0, loader.spawned.Count);

    }

}
