using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float remainingTimeInSeconds = 4.0f;

    [SerializeField] private bool timerIsRunning = true;
    public void SetTimerIsRunning(bool setTo)
    {
        timerIsRunning = setTo;
        return;

    }
    public bool GetTimerIsRunning()
    {
        return timerIsRunning;

    }



    private void TimerTick()
    {
        remainingTimeInSeconds -= Time.deltaTime;

    }
    private void TimerEnded()
    {
        timerIsRunning = false;
        remainingTimeInSeconds = 0f;
        GameManager.inst.RanOutOfTime();

    }
    

    private void Update()
    {
        if(timerIsRunning)
        {
            if(remainingTimeInSeconds >= 0.0f)
            {
                TimerTick();

            }
            else
            {
                TimerEnded();

            }

        }

        timerText.text = remainingTimeInSeconds.ToString("F2");

    }

}
  