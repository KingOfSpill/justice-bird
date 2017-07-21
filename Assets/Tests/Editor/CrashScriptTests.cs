using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CrashScriptTests {

	[Test]
	public void startDisablesDeadScreen()
    {

        GameObject deadScreen = new GameObject();
        GameObject bird = new GameObject();
        CrashScript crashScript = bird.AddComponent<CrashScript>();

        crashScript.deadScreen = deadScreen;

        crashScript.Start();

        Assert.IsFalse(deadScreen.activeSelf);

	}

    [Test]
    public void collisionWithNPCEnablesDeadScreen()
    {

        GameObject deadScreen = new GameObject();
        GameObject bird = new GameObject();
        CrashScript crashScript = bird.AddComponent<CrashScript>();

        GameObject npc = new GameObject();
        SphereCollider npcCollider = npc.AddComponent<SphereCollider>();
        npc.tag = "NPC";

        crashScript.deadScreen = deadScreen;
        deadScreen.SetActive(false);

        crashScript.OnTriggerEnter(npcCollider);

        Assert.IsTrue(deadScreen.activeSelf);

    }

    [Test]
    public void collisionWithNPCStopsTime()
    {

        GameObject deadScreen = new GameObject();
        GameObject bird = new GameObject();
        CrashScript crashScript = bird.AddComponent<CrashScript>();

        GameObject npc = new GameObject();
        SphereCollider npcCollider = npc.AddComponent<SphereCollider>();
        npc.tag = "NPC";

        crashScript.deadScreen = deadScreen;

        crashScript.OnTriggerEnter(npcCollider);

        Assert.IsTrue(Time.timeScale == 0.0f);

    }

    [Test]
    public void collisionWithObstacleEnablesDeadScreen()
    {

        GameObject deadScreen = new GameObject();
        GameObject bird = new GameObject();
        CrashScript crashScript = bird.AddComponent<CrashScript>();

        GameObject obstacle = new GameObject();
        SphereCollider obstacleCollider = obstacle.AddComponent<SphereCollider>();
        obstacle.tag = "Obstacle";

        crashScript.deadScreen = deadScreen;
        deadScreen.SetActive(false);

        crashScript.OnTriggerEnter(obstacleCollider);

        Assert.IsTrue(deadScreen.activeSelf);

    }

    [Test]
    public void collisionWithObstacleStopsTime()
    {

        GameObject deadScreen = new GameObject();
        GameObject bird = new GameObject();
        CrashScript crashScript = bird.AddComponent<CrashScript>();

        GameObject obstacle = new GameObject();
        SphereCollider obstacleCollider = obstacle.AddComponent<SphereCollider>();
        obstacle.tag = "Obstacle";

        crashScript.deadScreen = deadScreen;

        crashScript.OnTriggerEnter(obstacleCollider);

        Assert.IsTrue(Time.timeScale == 0.0f);

    }

}
