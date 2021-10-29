using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneWhenLowerThan : MonoBehaviour
{
    [SerializeField] private GameObject targetTransform;

    void Update()
    {
        if(targetTransform.transform.position.y < this.transform.position.y)
        {
            GameManager.inst.FellOut();

        }
    }

}
