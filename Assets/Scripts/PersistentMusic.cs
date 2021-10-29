using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentMusic : MonoBehaviour
{
    private static PersistentMusic _instance;

    public static PersistentMusic Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.Log(this + " is not unique and is destroyed");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log(this + " claims to be the unique singleton");
            _instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
