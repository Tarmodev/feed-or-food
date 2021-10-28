using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public string scorePrefix = "Food: ";
    [SerializeField] public float neededScore = 100.0f;

    public float score = 0;



    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void LoadNextSceneInQueue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void OnNextLevelButtonPressed()
    {
        print("OnNextLevelButtonPressed()");
        LoadNextSceneInQueue();

    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString() + "/" + neededScore.ToString("f0");

    }

    public void AddScore(float byHowMuch)
    {
        score += byHowMuch;
        UpdateScoreText();

    }

    public void RanOutOfTime()
    {
        // your code here :)
    }

    public void FellOutOfBounds()
    {

    }

    private void Awake()
    {
        inst = this;

    }
    private void Start()
    {
        
    }

}
