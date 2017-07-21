using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class FoodRotatorTests {

	[Test]
	public void updateChangesRotation()
    {
        GameObject food = new GameObject();
        FoodRotator rotator = food.AddComponent<FoodRotator>();

        Quaternion oldRotation = food.transform.rotation;

        rotator.Update();

        Assert.AreNotEqual(oldRotation, food.transform.rotation);
	}
}
