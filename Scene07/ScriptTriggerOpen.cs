using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTriggerOpen : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {

        if (other.gameObject.tag == "Trigger")
        {
            //Debug.Log ("triggered");
            SceneManager.LoadScene("Scene08");
        }
     
    }
}
