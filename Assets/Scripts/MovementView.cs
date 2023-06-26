using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementView : MonoBehaviour
{   
    [SerializeField] 
    private TextMeshProUGUI _playerMovementCountLabel;

    public void SetPlayerMovementCount(int count)
    {
        _playerMovementCountLabel.text = count.ToString();
    }
}
