using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PoopControllerTests {

	[Test]
	public void PoopFalls()
    {

        GameObject poop = new GameObject();
        PoopController poopController = poop.AddComponent<PoopController>();

        float y = poop.transform.position.y;

        poopController.Update();

        Assert.Greater(y, poop.transform.position.y);

	}

}
