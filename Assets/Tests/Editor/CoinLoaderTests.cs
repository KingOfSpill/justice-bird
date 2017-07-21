using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class CoinLoaderTests {

	[Test]
	public void CoinLoaderLoadsNumberOfCoins() {

        GameObject loaderObject = new GameObject();
        CoinLoader loader = loaderObject.AddComponent<CoinLoader>();
        Text text = loaderObject.AddComponent<Text>();

        loader.coins = -1;

        loader.Start();

        Assert.AreNotEqual(-1, loader.coins);

	}

    [Test]
    public void CoinLoaderSetsText()
    {

        GameObject loaderObject = new GameObject();
        CoinLoader loader = loaderObject.AddComponent<CoinLoader>();
        Text text = loaderObject.AddComponent<Text>();

        text.text = null;

        loader.Start();

        Assert.IsNotNull(text.text);

    }

    [Test]
    public void BuyReducesNumberOfCoins()
    {

        GameObject loaderObject = new GameObject();
        CoinLoader loader = loaderObject.AddComponent<CoinLoader>();
        Text text = loaderObject.AddComponent<Text>();

        loader.coins = 2;

        loader.Buy(1);

        Assert.Greater(2, loader.coins);

    }

    [Test]
    public void BuyChangesText()
    {

        GameObject loaderObject = new GameObject();
        CoinLoader loader = loaderObject.AddComponent<CoinLoader>();
        Text text = loaderObject.AddComponent<Text>();

        text.text = null;

        loader.Buy(1);

        Assert.IsNotNull(text.text);

    }

}
