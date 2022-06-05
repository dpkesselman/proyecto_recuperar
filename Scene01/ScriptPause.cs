using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPause : MonoBehaviour
{
    void  OnGUI (){
	    if ( GUI.Button( new Rect(10,10,80,80), "►ІІ") )
        {
		    if(Time.timeScale == 1){    //si la velocidad es 1
		    	Time.timeScale = 0; 	//que la velocidad del juego sea 0
		    } 
            else if(Time.timeScale == 0) {   // si la velocidad es 0
			    Time.timeScale = 1;  	// que la velocidad del juego regrese a 1
	    	}
	    }
    }
}
