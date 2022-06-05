using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTriggerSc03 : MonoBehaviour
{

    void OnTriggerEnter (Collider other) 
    {
        if(other.gameObject.tag == "Trigger")

        {
            Debug.Log ("pasa a siguiente escena");
            SceneManager.LoadScene("Scene04");
        }
    }
}
