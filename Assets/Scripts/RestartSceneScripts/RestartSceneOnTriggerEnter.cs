using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneOnTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.inst.ReloadScene();

    }
    
}

