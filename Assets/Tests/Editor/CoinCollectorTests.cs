﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class CoinCollectorTests {

	[Test]
	public void destroyCoinDestroysCoin() {        

        GameObject collectorObject = new GameObject();
        CoinCollector coinCollector = collectorObject.AddComponent<CoinCollector>();

        GameObject uiContainer = new GameObject();
        uiContainer.AddComponent<AudioSource>();
        coinCollector.ui = uiContainer.AddComponent<UIscript>();
        coinCollector.ui.coinText = uiContainer.AddComponent<Text>();

        GameObject coin = new GameObject();

        coinCollector.DestroyCoin(coin);

        Assert.IsTrue(!coin.activeSelf);

	}

    [Test]
    public void destroyCoinGetsCoin()
    {

        GameObject collectorObject = new GameObject();
        CoinCollector coinCollector = collectorObject.AddComponent<CoinCollector>();

        GameObject uiContainer = new GameObject();
        uiContainer.AddComponent<AudioSource>();
        coinCollector.ui = uiContainer.AddComponent<UIscript>();
        coinCollector.ui.coinText = uiContainer.AddComponent<Text>();

        GameObject coin = new GameObject();

        int oldCoins = coinCollector.ui.coins;

        coinCollector.DestroyCoin(coin);

        Assert.IsTrue( coinCollector.ui.coins > oldCoins );

    }

}
