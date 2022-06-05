using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptOpen : MonoBehaviour
{
    private Quaternion localRotation;  
    public float speed = 0.1f; // ajustable speed from Inspector in Unity editor
 

    void Start () 
    {
        // copy the rotation of the object itself into a buffer   
        localRotation = transform.rotation;
    }
     
     
    void FixedUpdate() // runs 60 fps or so
    {
        
        // find speed based on delta
        float curSpeed = Time.deltaTime * speed;

        // first update the current rotation angles with input from acceleration axis
        localRotation.z += -Input.acceleration.x * curSpeed;
        
        // then rotate this object accordingly to the new angle
        transform.rotation = localRotation;

    }

}