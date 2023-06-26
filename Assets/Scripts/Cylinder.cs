using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cylinder : MonoBehaviour

{
    public UnityEvent<Cylinder> EnemyDiedEvent;
    public Color Color => _color;

    [SerializeField] 
    private Renderer _renderer;
    private Color _color;

    public void Initialize(Color color)
    {
        _renderer.material.color = color;
        _color = color;
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        var color = collision.gameObject.GetComponent<Renderer>().material.color;
        if (color == gameObject.GetComponent<Renderer>().material.color)
        {
          
            EnemyDiedEvent.Invoke(this);
            Destroy(gameObject);
            
        } 
    }
    
}
