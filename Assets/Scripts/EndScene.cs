using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    [SerializeField] private GameObject winScreenUI;
    [SerializeField] private GameObject loseScreenUI;
    [SerializeField] private GameObject player;
    private Player playerScript;


    void Start()
    {
        playerScript = player.GetComponent<Player>();

    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerScript.SetControl(false);
            
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
