using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    [SerializeField] private GameObject winScreenUI;
    [SerializeField] private GameObject loseScreenUI;



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


            if (GameManager.inst.score < GameManager.inst.neededScore)
            {
                loseScreenUI.SetActive(true);

            }
            else
            {
                winScreenUI.SetActive(true);

            }


        }

    }

}
