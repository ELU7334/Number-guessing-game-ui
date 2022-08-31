using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuessingGame : MonoBehaviour
{
    
    int minValue;
    int maxValue;
     private TextMeshProUGUI guessText;
     int guess;

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
     minValue = guess + 1; 
          NextGuess();
   }

   public void OnPressLower()
{
       maxValue = guess - 1;
       NextGuess();
        // code
}

public void NextGuess()
{
  guess = Random.Range(minValue, maxValue + 1);
  guessText.text = guess.ToString();
}

    void StartGame()
       {
        NextGuess();

       }
}
