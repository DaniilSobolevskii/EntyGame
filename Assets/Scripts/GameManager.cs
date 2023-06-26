using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]private GameManager _gameManager;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private ColorManager _colorManager;
    [SerializeField] private Counter _counter;
    [SerializeField] private CylinderControler _cylinder;
 
    private Color[] _colors;

    void Awake()
    {
        _cylinder.Initialized(_prefab,_gameManager,_colorManager);

        GameObject sphere = Instantiate(_spherePrefab);
        sphere.GetComponent<Sphere>().Inizialized(this, _colorManager);
        GetRandomPosition(sphere);
        sphere.GetComponent<Renderer>().material.color = _colorManager.GetColor();
        
        
        _counter.Iniziailize(_colorManager);



    }

    public void UpdatePositions()
    {
        _cylinder.Initialized(_prefab,_gameManager, _colorManager);
    }
    
    public void GetRandomPosition(GameObject cylinder)
    {
        var cylinderPosition = cylinder.transform.position;
        var ran = Random.Range(-30,30);
        var ran2 = Random.Range(-12, 25);
        cylinderPosition.x += ran;
        cylinderPosition.z += ran2;
        cylinder.transform.position = cylinderPosition;
    }

   
}
