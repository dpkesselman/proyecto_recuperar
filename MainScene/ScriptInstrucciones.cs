using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptInstrucciones : MonoBehaviour
{   
    void OnTriggerEnter (Collider other) 
    {
        if(other.gameObject.tag == "Trigger")

        {
            SceneManager.LoadScene("Instrucciones1");
        }
    }
}
