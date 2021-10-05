//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    [SerializeField] private float score = 100f;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name != "Player")
        //{
            //return;
        //}

        GameManager.inst.AddScore(score);

        Destroy(gameObject);
        return;

    }

}
