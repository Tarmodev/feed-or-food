using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            GameManager.inst.restartScene();

        }
    }
}
