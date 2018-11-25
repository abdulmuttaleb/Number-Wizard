using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max, min, guess;
    [SerializeField] Text currentGuess;
	void Start () {
        StartGame();
	}
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min,max);
        max += 1;
    }

	void Update () {
        currentGuess.text = guess.ToString();
	}

    public void HigherGuess() {
        min = guess;
        NextGuess();
    }
    public void LowerGuess() {
        max = guess;
        NextGuess();
    }

    public void CorrectAnswer() {
        Debug.Log("I am a genius.");
        SceneManager.LoadScene(2);
       // StartGame();
    }

    void NextGuess()
    { 
        Debug.Log("Is it higher or lower than... " + guess);
        guess = Random.Range(min,max);
    }
}
