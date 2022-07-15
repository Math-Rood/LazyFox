using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
