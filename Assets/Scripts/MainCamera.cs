using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private Transform targetObject;

    private Vector3 offset;
    private Vector3 targetPos;

    // Start is called before the first frame update
    private void Start() {
        offset = transform.position - targetObject.position;
        
    }

    private void LateUpdate()
    {
        Vector3 targetPos = targetObject.position + offset;
        transform.position = targetPos;
        transform.rotation = targetObject.rotation;

    }

}
