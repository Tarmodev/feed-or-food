//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;


    [SerializeField]
    Text scoreText;
    [SerializeField]
    string scorePrefix = "Food: ";

    private float score = 0;



    private void Awake()
    {
        // Create singleton.
        inst = this;

    }

    public void updateScoreText()
    {
        scoreText.text = scorePrefix + score.ToString();

    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void addScore(float byHowMuch)
    {
        score += byHowMuch;
        updateScoreText();

    }

    //// Start is called before the first frame update
    //private void Start()
    //{
        
    //}

    //// Update is called once per frame
    //private void Update()
    //{
        
    //}

}
