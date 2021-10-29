using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{

    public void LoadNextScene()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
	}

	public void Quitgame()
	{
        Application.Quit();
	}
}
