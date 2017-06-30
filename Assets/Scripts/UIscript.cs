using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    public Text scoreText;
    public Text coinText;
    public Button testpoopbutton;
    public Button testCoinButton;
    public Image poopFill;

    private int score = 0;
    private int delay = 0;
    private int coins = 0;
    private int pooAmount = 0;
    
	// Use this for initialization
	void Start () {
        //Button poohit = testpoopbutton.GetComponent<Button>();
        testpoopbutton.onClick.AddListener(poopHit);
        testpoopbutton.onClick.AddListener(foodCollected);
        testCoinButton.onClick.AddListener(getCoin);
        testCoinButton.onClick.AddListener(bowelMovement);
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
        GetComponent<AudioSource>().Play();
        coins++;
        coinText.text = "X " + coins.ToString();
    }

    public void foodCollected()
    {
        if(pooAmount == 0)
        {
            poopFill.enabled = true;
            pooAmount++;
            return;
        }
        else if(pooAmount == 10)
        {
            return;
        }
        else
        {
            float currentHeight = poopFill.rectTransform.rect.height;
            float currentWidth = poopFill.rectTransform.rect.width;
            poopFill.rectTransform.offsetMax = new Vector2(poopFill.rectTransform.offsetMax.x, poopFill.rectTransform.offsetMax.y + 19);
            pooAmount++;
        }
    }

    public void bowelMovement()
    {
        if(pooAmount == 0)
        {
            return;
        }
        else if(pooAmount == 1)
        {
            poopFill.enabled = false;
            pooAmount--;
        }
        else
        {
            float currentHeight = poopFill.rectTransform.rect.height;
            float currentWidth = poopFill.rectTransform.rect.width;
            poopFill.rectTransform.offsetMax = new Vector2(poopFill.rectTransform.offsetMax.x, poopFill.rectTransform.offsetMax.y - 19);
            pooAmount--;
        }
    }
}


