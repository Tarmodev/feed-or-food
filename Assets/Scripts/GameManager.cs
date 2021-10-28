using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public string scorePrefix = "Food: ";
    [SerializeField] public float neededScore = 100.0f;

    [SerializeField] private GameObject winScreenUI;
    [SerializeField] private GameObject loseScreenUI;
    [SerializeField] private GameObject timeOutScreenUI;



    [SerializeField] private GameObject gameObjectWithPlayerScript;
    [SerializeField] private GameObject gameObjectWithTimerScript;


    private Player playerScript;
    private Timer timerScript;


    public float score = 0;



    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void LoadNextSceneInQueue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void QuitToStartScreen()
    {
        SceneManager.LoadScene("StartScreen");

    }

    public void OnNextLevelButtonPressed()
    {
        //print(this + "helo");
        LoadNextSceneInQueue();

    }
    public void OnRestartButtonPressed()
    {
        ReloadScene();

    }
    public void OnQuitButtonPressed()
    {
        QuitToStartScreen();

    }

    public void Finish() {

        playerScript.SetControl(false);
        timerScript.SetTimerIsRunning(false);


        if (inst.score < inst.neededScore)
        {
            loseScreenUI.SetActive(true);

        }
        else
        {
            winScreenUI.SetActive(true);

        }
        
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
        timeOutScreenUI.SetActive(true);
        playerScript.SetControl(false);
        
        // Causes a bug:
        //Time.timeScale = 0.0f;

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
        playerScript = gameObjectWithPlayerScript.GetComponent<Player>();
        timerScript = gameObjectWithTimerScript.GetComponent<Timer>();

    }

}
