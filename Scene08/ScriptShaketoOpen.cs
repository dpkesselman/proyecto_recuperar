using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptShaketoOpen : MonoBehaviour
{
    Vector3 acceDir;
    void Update()
    {
        acceDir = Input.acceleration;
        if (acceDir.sqrMagnitude >=3f)
        {
            SceneManager.LoadScene("Scene09");
        }        

    }
}
