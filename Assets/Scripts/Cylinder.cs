using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Renderer>().material.color ==
            gameObject.GetComponent<Renderer>().material.color)
        {
            Destroy(gameObject);
        } 
    }
    
}
