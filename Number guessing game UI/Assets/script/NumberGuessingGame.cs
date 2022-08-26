using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
       int guess = 5;
    int minValue = 1;
    int maxValue = 10;
    // Start is called before the first frame update
    void Start()
    {
      
       StartGame();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow))
       {
          minValue = guess; 
          guess = (maxValue + minValue) / 2;
          Debug.Log("Is it higher or lower than: " + guess);
       }
       if(Input.GetKeyDown(KeyCode.DownArrow)) 
       {
        maxValue = guess;
        guess = (maxValue) / 2;
        Debug.Log("Is it higher or lower than : " + guess); 
       }
       
        if(Input.GetKeyDown(KeyCode.Return)) 
        {
        Debug.Log("I guessed your number, I'm a genius");
        Debug.Log("");
        StartGame();
         }
    }

    void StartGame()
       {
        guess =5;
        minValue = 1;
        maxValue = 10;

        Debug.Log("Welcome to our Number Guessing Game.");
        Debug.Log("The number range is from " + minValue +" and" + maxValue);
        Debug.Log("guess a number between the range. ");
        Debug.Log("tell me if your number is higher or lower that:" + guess + "?");
        Debug.Log("push up arrow = Higher, Push Down Arrow = Lower, Push Enter = Correct");
        maxValue = maxValue + 1;
       }
}
