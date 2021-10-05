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
        // Create singleton.
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

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void updateScoreText()
    {
        scoreText.text = scorePrefix + score.ToString();

    }

    public void addScore(float byHowMuch)
    {
        score += byHowMuch;
        updateScoreText();

    }

    public void endScene()
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
