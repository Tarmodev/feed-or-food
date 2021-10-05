using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    
    [SerializeField] private Text scoreText;
    [SerializeField] private string scorePrefix = "Food: ";
    [SerializeField] private float neededScore = 100.0f;

    private float score = 0;

    private string output = "";


    private void Awake()
    {
        inst = this;

    }

    private void Start()
    {
        
    }
    
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void UpdateScoreText()
    {
        scoreText.text = scorePrefix + score.ToString();

    }

    public void AddScore(float byHowMuch)
    {
        score += byHowMuch;
        UpdateScoreText();

    }

    public void EndScene()
    {
        if(score < neededScore)
        {
            output += "You lose! :(";
        }
        else
        {
            output += "You win! :)";
        }
        
        output += " " + scorePrefix + score.ToString();
        
        Debug.Log(output);
        
    }

}
