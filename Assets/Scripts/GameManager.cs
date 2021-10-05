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
    [SerializeField]
    float neededScore = 100.0f;

    private float score = 0;



    private void Awake()
    {
        inst = this;

    }
    
    //// Start is called before the first frame update
    //private void Start()
    //{

    //}

    //// Update is called once per frame
    //private void Update()
    //{

    //}

    public void RestartScene()
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
            Debug.Log("You lose! :(");
        }
        else
        {
            Debug.Log("You win! :)");
        }

        Debug.Log("Food: " + score);
    }

}
