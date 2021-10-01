using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneOnCollision : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.inst.restartScene();

    }
}
