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
        NextGuess();
    }

	void Update () {
        currentGuess.text = guess.ToString();
	}

    public void HigherGuess() {
        min = guess + 1;
        NextGuess();
    }
    public void LowerGuess() {
        max = guess -1;
        NextGuess();
    }

    public void CorrectAnswer() {
        SceneManager.LoadScene(2);
       // StartGame();
    }

    void NextGuess()
    { 
        guess = Random.Range(min,max+1);
    }
}
