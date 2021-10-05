using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneOnTriggerEnter : MonoBehaviour
{
    //[SerializeField]
    //readonly string strTag = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.inst.RestartScene();

    }
    
}

