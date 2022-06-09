using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
  
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void InstructionsContinue()
    {
        SceneManager.LoadScene(2);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
