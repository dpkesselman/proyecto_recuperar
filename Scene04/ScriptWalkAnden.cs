using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWalkAnden : MonoBehaviour
{
   float speed = 5.0f;
    Vector3 startPos;

    void Start ()
    {
        startPos = this.transform.position;
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.y = -Input.acceleration.y;

        if (dir.sqrMagnitude > 5)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        transform.Translate(dir * speed);
    }

    void OnTriggerEnter (Collider other)

    {
        if (other.gameObject.tag == "Triggered")
        {
            this.transform.position = startPos;            
        }
    }
}
