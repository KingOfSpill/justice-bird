using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CoinFlightControllerTests {
    
    [Test]
    public void StartFindsBird()
    {

        GameObject mainCamera = new GameObject("Main Camera");
        GameObject bird = new GameObject("Bird");

        bird.transform.SetParent(mainCamera.transform);

        GameObject coin = new GameObject();
        CoinFlightController coinFlightController = coin.AddComponent<CoinFlightController>();

        coinFlightController.Start();

        Assert.NotNull(coinFlightController.bird);

    }

    [Test]
	public void UpdateMovesCoinTowardBirds() {

        GameObject mainCamera = new GameObject("Main Camera");
        GameObject bird = new GameObject("Bird");

        bird.transform.SetParent(mainCamera.transform);

        bird.transform.position = new Vector3(10f, 10f, 10f);

        GameObject coin = new GameObject();
        CoinFlightController coinFlightController = coin.AddComponent<CoinFlightController>();

        Vector3 oldPosition = coin.transform.position;

        coinFlightController.Start();
        coinFlightController.Update();

        Assert.Greater(Vector3.Distance(oldPosition, bird.transform.position), Vector3.Distance(coin.transform.position, bird.transform.position));

	}

}
