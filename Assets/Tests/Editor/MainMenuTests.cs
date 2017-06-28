using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuTests {

	[Test]
	public void MainMenuExists(){

		Assert.IsTrue( SceneManager.GetSceneByName("MainMenu").IsValid() );

	}

}
