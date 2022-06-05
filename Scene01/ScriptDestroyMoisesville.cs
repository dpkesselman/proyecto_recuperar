using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDestroyMoisesville : MonoBehaviour
{
    void Awake ()
    {
        Destroy(GameObject.FindWithTag("Music"));        
    }
}
