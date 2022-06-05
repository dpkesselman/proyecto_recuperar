using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDontDestroyGUI : MonoBehaviour
{
    void Awake()
    {
        GameObject[] GUI = GameObject.FindGameObjectsWithTag("UI");
        DontDestroyOnLoad(this.gameObject);
    }
}
