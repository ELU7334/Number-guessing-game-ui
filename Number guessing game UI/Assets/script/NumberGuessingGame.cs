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
   public void OnPressHigher()
   {
     minValue = guess; 
          guess = (maxValue + minValue) / 2;
          Debug.Log("Is it higher or lower than: " + guess);
   }

   public void OnPressLower()
{
maxValue = guess;
        guess = (maxValue) / 2;
        Debug.Log("Is it higher or lower than : " + guess);
}

public void NextGuess()
{

}

    void StartGame()
       {
        guess =5;
        minValue = 1;
        maxValue = 10;

        
        
       }
}
