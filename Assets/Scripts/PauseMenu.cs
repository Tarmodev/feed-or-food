using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private KeyCode pauseKey = KeyCode.Escape;
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    [SerializeField] private string sceneToLoadWhenQuit;


    public void UnpauseGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;

    }



    public void LoadMenu()
    {
        UnpauseGame();
        SceneManager.LoadScene(sceneToLoadWhenQuit);

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (gameIsPaused)
            {
                UnpauseGame();

            }
            else
            {
                PauseGame();

            }


        }

    }

}
