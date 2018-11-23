using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max, min;
	void Start () {
        max = 1000;
        min = 1;
        Debug.Log("Hello to Number Wizard..");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Choose a number between: "+min+" and: "+max);
        Debug.Log("Tell me if your number is higher orr lower than my guess!");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed!");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
        }
	}
}
