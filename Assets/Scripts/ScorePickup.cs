//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    [SerializeField] float score = 100f;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name != "Player")
        //{
            //return;
        //}

        GameManager.inst.addScore(score);

        Destroy(gameObject);
        return;

    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

}
