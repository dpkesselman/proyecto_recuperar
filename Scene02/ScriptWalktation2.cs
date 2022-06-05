using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptWalktation2 : MonoBehaviour
{
    Vector3 acceDir;
    void Update()
    {
        acceDir = Input.acceleration;
        if (acceDir.sqrMagnitude >=3f)
        {
            SceneManager.LoadScene("Scene03");
        }        

    }
}
