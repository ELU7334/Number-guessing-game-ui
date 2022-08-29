using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene()
   {
    int currentScemeIndex = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentScemeIndex + 1);
   }
public void LoadStartScene()
{
      SceneManager.LoadScene(0);
}
   public void QuitGame()
   {
       Application.Quit();
   }
}
