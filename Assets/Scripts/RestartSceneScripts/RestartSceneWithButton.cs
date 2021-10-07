using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneWithButton : MonoBehaviour
{
    [SerializeField] private KeyCode keyRestart;

    void Update()
    {
        if (Input.GetKeyDown(keyRestart))
        {
            GameManager.inst.ReloadScene();

        }
    }
}
