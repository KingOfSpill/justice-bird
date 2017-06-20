using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    public Text scoreText;
    public Button testpoopbutton;

    private int score = 0;
    private int delay = 0;
    
	// Use this for initialization
	void Start () {
        //Button poohit = testpoopbutton.GetComponent<Button>();
        testpoopbutton.onClick.AddListener(poopHit);
        printScore();
	}
	
	// Update is called once per frame
	void Update () {
        if(delay % 100 == 0)
        {
            score++;
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
}
