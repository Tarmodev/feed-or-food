using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private KeyCode pauseKey = KeyCode.Escape;
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;



    public void Continue()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;

    }

    public void QuitGame()
    {
        print("quitting game...");
        Application.Quit();

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (gameIsPaused)
            {
                Continue();

            }
            else
            {
                Pause();

            }


        }

    }

}
