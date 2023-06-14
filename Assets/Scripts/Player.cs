using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private ColorManager _colorManager;

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)&& Physics.Raycast(ray,out var hit))
        {
            var direction = (hit.point - transform.position).normalized;
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(new Vector3(direction.x, 0, direction.z)*500);
        }
        
    }
    

    
}
