using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        GameIsPaused = false;
        
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        GameIsPaused = true;
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        
    }
    public void ResetMenu()
    {
        SceneManager.LoadScene(3);
        
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
