using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptWindowViews : MonoBehaviour
{
    public GameObject vista1;
    public GameObject vista2;
    //AudioSource audioData;
    Vector3 startPosV1;
    Vector3 startPosV2;
    //short c = 0;
    public GameObject videoPlayer;
    public GameObject videoPlayer2;

    void Start()
    {
        startPosV1 = vista1.transform.position;
        startPosV2 = vista2.transform.position;
        //audioData = GetComponent<AudioSource>();
        videoPlayer.SetActive(false);
        videoPlayer2.SetActive(false);
    }

    void Update()
    {
        transform.Translate(new Vector2(Input.acceleration.x, Input.acceleration.y) * Time.deltaTime * 5f);
    }

    
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "triggerDer")
        {               
            //vista1.transform.Translate(new Vector2(-200,0) * Time.deltaTime * 5f);
            videoPlayer2.SetActive(true);            
        }

        if (other.gameObject.tag == "triggerIzq")
        {               
            videoPlayer.SetActive(true);
            //vista2.transform.Translate(new Vector2(110,0) * Time.deltaTime * 10f);            
        }

        /*if (other.gameObject.tag == "triggerArriba")
        {               
            c++;

            if (c == 1)
            {
                audioData = GetComponent<AudioSource>();
                audioData.Play();
                Debug.Log("Suena música");
            }

            if (c == 2 || (c ==4))
            {
                audioData.Pause();
                Debug.Log("Pausa música");
            }

            if (c == 3 || (c == 5))
            {
                audioData.UnPause();
                Debug.Log("Continúa música");
            }              
        }*/
                
                
        if (other.gameObject.tag == "triggerAbajo")
        {               
            SceneManager.LoadScene("Scene06");
        }

    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "triggerDer")
        {               
            videoPlayer2.SetActive(false);
            //vista1.transform.position = startPosV1;            
        }

        if (other.gameObject.tag == "triggerIzq")
        {               
            videoPlayer.SetActive(false);
            //vista2.transform.position = startPosV2;            
        }
    }

}