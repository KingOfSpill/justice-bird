using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    public Text scoreText;
    public Text coinText;
    public Image poopFill;

    private int score = 0;
    private int delay = 0;
    public int coins = 0;
    public int pooAmount = 0;
    
	void Start ()
    {
        coinText.text = "X " + coins.ToString();
        printScore();
	}
	
	void Update ()
    {

        if(delay % 100 == 0)
            changeScore(1 * (int)Time.timeScale);

        delay++;

	}

    void printScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void changeScore( int scoreChange)
    {

        score += scoreChange;
        printScore();

    }

    void poopHit()
    {
        changeScore(100);
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

    public bool bowelMovement()
    {
        if(pooAmount == 0)
        {
            return false;
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

        return true;
    }

    public void saveCoins()
    {
        SaveLoad.saveNumberOfCoins(SaveLoad.loadNumberOfCoins() + coins);
    }
}


