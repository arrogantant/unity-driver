using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("yee");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("what?");
    }
}
