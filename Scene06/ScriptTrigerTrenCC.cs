using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTrigerTrenCC : MonoBehaviour
{
    int c = 0;
    public AudioSource audioSource;
    public GameObject pisadas;

    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.tag == "Triggered")
        {
            c++;
            if (c < 5)
            {
                audioSource.Play();
            }
            
            Debug.Log("Triggered" + c);
            
            float x = Random.Range (-5, 5);
            float y = Random.Range (-3, 3);
            pisadas.transform.position = new Vector2(x,y);            
        }

        if (c >= 5)
        {
            SceneManager.LoadScene("Scene07");
        }
                         
    }
}
