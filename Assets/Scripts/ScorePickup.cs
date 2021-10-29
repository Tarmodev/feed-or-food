//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ScorePickup : MonoBehaviour
{
    [SerializeField] private float score;
    [SerializeField] Transform pickupEffect;
    [SerializeField] AudioClip pickupSound;


    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name != "Player")
        //{
            //return;
        //}

        GameManager.inst.AddScore(score);
        Instantiate(pickupEffect,transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(pickupSound, transform.position);

        Destroy(gameObject);
        return;

    }

}
