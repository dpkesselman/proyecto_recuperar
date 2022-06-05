using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptDontDestroyMoisesville : MonoBehaviour
{
  /*  void Awake()
    {
        GameObject[] Music = GameObject.FindGameObjectsWithTag("Music");
        DontDestroyOnLoad(this.gameObject);        

        if (GameObject.FindGameObjectsWithTag("Music").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("Music"));
        }
    }
    */

    public static ScriptDontDestroyMoisesville instance;
 
    void Awake () {
         
         if (instance == null) {
 
             DontDestroyOnLoad (gameObject);
             instance = this;
         } else if (instance != this) {
             Destroy (gameObject);
         }
 
     }
}
