using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    
    [SerializeField] private Text scoreText;
    [SerializeField] public string scorePrefix = "Food: ";
    [SerializeField] public float neededScore = 100.0f;

    public float score = 0;



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

}
