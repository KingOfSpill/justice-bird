using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuTests {

	[UnityTest]
	public IEnumerator StartButtonLoadsGame(){

		SceneManager.LoadScene("MainMenu");

		yield return new WaitForSecondsRealtime(2);

		GameObject.Find("/Canvas/StartButton").GetComponent<Button>().onClick.Invoke();

		yield return new WaitForSecondsRealtime(2);

		Assert.IsTrue( SceneManager.GetSceneByName("MainMenu") != SceneManager.GetActiveScene() );

	}

}
