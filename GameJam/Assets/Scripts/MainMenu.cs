using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("Level1");
    }

   public void QuitGame()
   {
       Application.Quit();
   }
}

