using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    
    private ColorManager _colorManager;

    [SerializeField] 
    private Image[] _image; 
    
    [SerializeField]
    private TextMeshProUGUI[] _score;
    private int x = 0;

    public void Iniziailize(ColorManager colorManager)
    {
        _colorManager = colorManager;
        Color[] _colors = _colorManager.GetAllColors();

        for (var i = 0; i < _colors.Length; i++)
        {
            var color = _colors[i];
            _image[i].color = color;
        }
    }

    public void SetCount(Color color, int count)
    {

        for (var i = 0; i < _image.Length; i++)
        {
            if (color == _image[i].color)
            {
                _score[i].text = count.ToString();
                break;
            }
        }


    }

}
