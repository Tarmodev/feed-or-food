//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    [SerializeField]
    Transform targetObject;
    Vector3 offset;
    Vector3 targetPos;

    // Start is called before the first frame update
    void Start() {
        offset = transform.position - targetObject.position;
        
    }

    //// Update is called once per frame
    //private void Update() {
        
    //}

    private void LateUpdate()
    {
        Vector3 targetPos = targetObject.position + offset;
        transform.position = targetPos;
        transform.rotation = targetObject.rotation;

    }

}
