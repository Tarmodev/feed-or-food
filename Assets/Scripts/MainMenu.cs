using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string sceneToLoadWhenStartIsPressed;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoadWhenStartIsPressed);

    }
    public void QuitGame()
    {
        Debug.Log("Quit game.");
        Application.Quit();

    }
}
