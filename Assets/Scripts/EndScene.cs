using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other);
            string message;

            if (GameManager.inst.score < GameManager.inst.neededScore)
            {
                message = "You lose! :( ";
            }
            else
            {
                message = "You win! :) ";
            }
            message += GameManager.inst.scorePrefix + GameManager.inst.score.ToString();

            Debug.Log(message);

        }

    }

}
