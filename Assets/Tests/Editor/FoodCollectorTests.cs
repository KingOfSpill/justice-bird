﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class FoodCollectorTests {

	[Test]
	public void destroyFoodDestroysFood() {

        GameObject collectorObject = new GameObject();
        FoodCollector foodCollector = collectorObject.AddComponent<FoodCollector>();

        GameObject uiContainer = new GameObject();
        collectorObject.AddComponent<AudioSource>();
        foodCollector.ui = uiContainer.AddComponent<UIscript>();
        foodCollector.ui.poopFill = uiContainer.AddComponent<Image>();

        GameObject food = new GameObject();

        foodCollector.ui.pooAmount = 1;

        foodCollector.DestroyFood(food);

        Assert.IsTrue(!food.activeSelf);

    }

    [Test]
    public void destroyFoodCollectsFood()
    {

        GameObject collectorObject = new GameObject();
        FoodCollector foodCollector = collectorObject.AddComponent<FoodCollector>();

        GameObject uiContainer = new GameObject();
        collectorObject.AddComponent<AudioSource>();
        foodCollector.ui = uiContainer.AddComponent<UIscript>();
        foodCollector.ui.poopFill = uiContainer.AddComponent<Image>();

        GameObject food = new GameObject();

        int oldFood = foodCollector.ui.pooAmount;

        foodCollector.DestroyFood(food);

        Assert.IsTrue(foodCollector.ui.pooAmount > oldFood);

    }

}
