using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class DataProvider : MonoBehaviour
{
    private string _summary = "Hello Space";
    [SerializeField] private Sprite _sprite;

    public string Summary => _summary;
    public Sprite Sprite => _sprite;
}
