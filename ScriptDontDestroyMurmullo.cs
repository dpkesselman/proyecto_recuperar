using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDontDestroySosa : MonoBehaviour
{

    void Awake()
    {
        GameObject[] Music = GameObject.FindGameObjectsWithTag("Noise");
        DontDestroyOnLoad(this.gameObject);
    }
}
