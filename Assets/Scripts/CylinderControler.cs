using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CylinderControler : MonoBehaviour
{

    public UnityEvent<Color, int> ChangeCylinderCountWithColor;

    [SerializeField] 
    private Cylinder _сylinder;

    public UnityEvent<Color, int> ChangeCountWithColor;

    private ColorManager colorManager;
    public Dictionary<Color, int> _enemyColorCount = new();


    public void Initialized(GameObject _prefab, GameManager _gameManager, ColorManager _colorManager)
    {
        colorManager = _colorManager;
        Color[] colors = colorManager.GetAllColors();

        foreach (var color in colors)
        {
            _enemyColorCount.Add(color, 0);

        }


        for (int i = 0; i < 6; i++)
        {
            var cylinder = Instantiate(_prefab);
            _gameManager.GetRandomPosition(cylinder);
            var newColor = colorManager.GetColor();
          //  _сylinder.Initialize(newColor);
            cylinder.GetComponent<Renderer>().material.color = newColor;
            _enemyColorCount[newColor] += 1;
            ChangeCountWithColor.Invoke(newColor, _enemyColorCount[newColor]);



        }
    }
}
//   private void EnemyDied(Cylinder cylinder)
 //   {
        // Уменьшаем на 1 количество врагов данного цвета.
        //  _enemyColorCount[cylinder.]--;
        
        // Вызываем событие изменения количества врагов данногоц цвета.
       // ChangeEnemiesCountWithColor.Invoke(enemyController.Color, _enemiesCountsByColor[enemyController.Color]);
    //}
    

