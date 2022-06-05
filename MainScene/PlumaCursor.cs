using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlumaCursor : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector2(Input.acceleration.x, 0) * Time.deltaTime * 5f);
    }
}
