using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entered Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered Trigger");
    }
}
