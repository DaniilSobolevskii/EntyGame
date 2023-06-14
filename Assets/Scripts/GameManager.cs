using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public partial class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private ColorManager _colorManager;


    void Awake()
    {
        for (int i = 0; i < 6; i++)
        {
            var cylinder = Instantiate(_prefab);
            GetRandomPosition(cylinder);
            cylinder.GetComponent<Renderer>().material.color = _colorManager.GetColor();
        }

        GameObject sphere = Instantiate(_spherePrefab);
        sphere.GetComponent<Sphere>().Inizialized(this, _colorManager);
        GetRandomPosition(sphere);
        sphere.GetComponent<Renderer>().material.color = _colorManager.GetColor();
        
    }

    public void UpdatePositions()
    {
        for (int i = 0; i < 6; i++)
        {
            
            var cylinder = Instantiate(_prefab,transform);
             GetRandomPosition(cylinder);
            cylinder.GetComponent<Renderer>().material.color = _colorManager.GetColor();
            
        }
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
