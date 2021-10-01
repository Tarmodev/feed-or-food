using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneWhenLowerThan : MonoBehaviour
{
    [SerializeField]
    GameObject targetTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetTransform.transform.position.y < this.transform.position.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
