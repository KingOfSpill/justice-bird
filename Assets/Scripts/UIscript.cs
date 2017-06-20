using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    public Text scoreText;
    public Text coinText;
    public Button testpoopbutton;
    public Button testCoinButton;

    private int score = 0;
    private int delay = 0;
    private int coins = 0;
    
	// Use this for initialization
	void Start () {
        //Button poohit = testpoopbutton.GetComponent<Button>();
        testpoopbutton.onClick.AddListener(poopHit);
        testCoinButton.onClick.AddListener(getCoin);
        coinText.text = "X " + coins.ToString();
        printScore();
	}
	
	// Update is called once per frame
	void Update () {
        if(delay % 100 == 0)
        {
            score += 1 * (int)Time.timeScale;
        }
 
        printScore();
        delay++;

	}

void printScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void poopHit()
    {
        score += 100;
    }

    public void getCoin()
    {
        coins++;
        coinText.text = "X " + coins.ToString();
    }
}
