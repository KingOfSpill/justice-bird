using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CoinSpawnerTests {

	[Test]
	public void CreateCoinSpawnsCoin()
    {
        GameObject coin = new GameObject();

        GameObject coinSpawnerObject = new GameObject();
        CoinSpawner coinSpawner = coinSpawnerObject.AddComponent<CoinSpawner>();

        coinSpawner.coin = coin;

        Assert.IsNotNull(coinSpawner.CreateCoin());

	}
}
