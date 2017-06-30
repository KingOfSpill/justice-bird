using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class UIScriptTests {

	[Test]
	public void getCoinChangesCoinCounterText() {

        GameObject uiContainer = new GameObject();
        UIscript ui = uiContainer.AddComponent<UIscript>();
        uiContainer.AddComponent<AudioSource>();
        UnityEngine.UI.Text txt = uiContainer.AddComponent<UnityEngine.UI.Text>();

        ui.coinText = txt;

        string coinText = txt.text;

        ui.getCoin();

        Assert.AreNotEqual(coinText, ui.coinText.text);

	}

    [Test]
    public void changeScoreChangesScoreText()
    {

        GameObject uiContainer = new GameObject();
        UIscript ui = uiContainer.AddComponent<UIscript>();
        uiContainer.AddComponent<AudioSource>();
        UnityEngine.UI.Text txt = uiContainer.AddComponent<UnityEngine.UI.Text>();

        ui.scoreText = txt;

        string scoreText = txt.text;

        ui.changeScore(100);

        Assert.AreNotEqual(scoreText, ui.scoreText.text);

    }

}
