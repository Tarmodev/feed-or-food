//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float score;
    public Text scoreText;

    public static GameManager inst;

    private void Awake()
    {
        // Create singleton.
        inst = this;
    }

    private void updateScoreText()
    {
        scoreText.text = "Food: " + score;
    }

    public void addScore(float increment)
    {
        score += increment;
        updateScoreText();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
