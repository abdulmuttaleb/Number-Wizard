using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max, min, guess;
	void Start () {
        StartGame();
	}
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Hello to Number Wizard..");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Choose a number between: " + min + " and: " + max);
        Debug.Log("Tell me if your number is higher or lower than my guess!");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius.");
            StartGame();
        }
	}

    void NextGuess()
    { 
        Debug.Log("Is it higher or lower than... " + guess);
        guess = (max + min) / 2;
    }
}
