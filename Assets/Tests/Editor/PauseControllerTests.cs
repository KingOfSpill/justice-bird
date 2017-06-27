using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PauseControllerTests {

	[Test]
	public void canPause(){

		// First we need to make an object to contain our script
		GameObject pauseControllerObject = new GameObject();

		// Then we add the script as a component
		PauseController pauseController = pauseControllerObject.AddComponent<PauseController>();

		// Then we initialize testing conditions
		pauseController.pauseScreen = new GameObject();
		pauseController.pauseScreen.SetActive(false);
		pauseController.isPaused = false;
		Time.timeScale = 1.0f;

		// Then we run the code we're testing
		pauseController.switchPause();

		// Then we check that the state is correct after that code runs
		Assert.IsTrue( Time.timeScale == 0.0f && pauseController.pauseScreen.activeSelf );

	}

	[Test]
	public void canUnPause(){

		// First we need to make an object to contain our script
		GameObject pauseControllerObject = new GameObject();

		// Then we add the script as a component
		PauseController pauseController = pauseControllerObject.AddComponent<PauseController>();

		// Then we initialize testing conditions
		pauseController.pauseScreen = new GameObject();
		pauseController.pauseScreen.SetActive(true);
		pauseController.isPaused = true;
		Time.timeScale = 0.0f;

		// Then we run the code we're testing
		pauseController.switchPause();

		// Then we check that the state is correct after that code runs
		Assert.IsTrue( Time.timeScale == 1.0f && !pauseController.pauseScreen.activeSelf );

	}

}
