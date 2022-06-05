using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripCursorTrenCC : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector2(Input.acceleration.x, Input.acceleration.y) * Time.deltaTime * 3f);
    }
}
