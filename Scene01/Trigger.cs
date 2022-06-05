using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    int c = 0;
    public AudioSource audioSource;
    public GameObject pisadas;

    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.tag == "Trigger")
        {
            c++;
            audioSource.Play();
            Debug.Log("Triggered" + c);
            pisadas.transform.Translate (0,3,-1);            
        }

        if (c >= 4)
        {
            SceneManager.LoadScene("Scene02");
        }
                         
    }
}
