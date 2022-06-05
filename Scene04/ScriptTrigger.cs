using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTrigger : MonoBehaviour
{
    int c = 0;
    public AudioSource audioSource;
    public GameObject pisadas;

    public SpriteRenderer trenllegandordr;
    public GameObject trenllegando;
    
     void Start()
    {
       trenllegandordr = trenllegando.GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.tag == "Trigger")
        {
            c++;
            if (c < 6)
            {
                audioSource.Play();
            }
            Debug.Log("Triggered" + c);
            pisadas.transform.Translate (0,2,0);                       
        }

        if (c == 2)
        {
            trenllegandordr.color = new Color (1, 1, 1, 0.7f);
        }

        if (c == 3)
        {
            trenllegandordr.color = new Color (1, 1, 1, 0.5f);
        }

        if (c == 4)
        {
            trenllegandordr.color = new Color (1, 1, 1, 0.3f);
        }

        if (c == 5)
        {
            trenllegandordr.color = new Color (1, 1, 1, 0);
        }

        if (c >= 6)
        {
            SceneManager.LoadScene("Scene05");
        }
                         
    }
}

