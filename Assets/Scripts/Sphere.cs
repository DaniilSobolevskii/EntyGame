using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private ColorManager _colorManager;
    private GameManager _gameManager;
    public void Inizialized(GameManager gm, ColorManager cm)
    {
        _gameManager = gm;
        _colorManager = cm;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var color = gameObject.GetComponent<Renderer>().material.color;  
        if (collision.gameObject.GetComponent<Player>())
        {
          collision.gameObject.GetComponent<Renderer>().material.color = color;
          gameObject.transform.position = new Vector3(0, 1, 0);
          _gameManager.GetRandomPosition(gameObject);
          GetNewColor(color);

        }
       
    }

    private void GetNewColor(Color color)
    {
        var newColor = _colorManager.GetColor();
        if (newColor != color)
        { 
            gameObject.GetComponent<Renderer>().material.color= newColor;
        }
        else
        {
            GetNewColor(color);
        }
        
    }
}
