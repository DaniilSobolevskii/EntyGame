using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ColorManager : MonoBehaviour
{
   [SerializeField] private Color[] _colors;

   public Color GetColor()
   {
       var random = Random.Range(0, _colors.Length);
       return _colors[random];
   }
}
