using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptIniciar : MonoBehaviour
{   void OnTriggerEnter (Collider other) 
    {
        if(other.gameObject.tag == "Trigger")

        {
            SceneManager.LoadScene("Scene01");
        }
    }
}
