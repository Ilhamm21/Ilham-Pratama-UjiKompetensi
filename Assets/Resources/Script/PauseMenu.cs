using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    
    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
