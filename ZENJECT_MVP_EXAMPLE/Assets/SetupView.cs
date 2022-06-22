using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupView : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;

    public void Init(string text, Sprite sprite)
    {
        _text.text = text;
        _image.sprite = sprite;
    }

    public void Init(View<string, Sprite> view)
    {
        _text.text = view.Summary;
        _image.sprite = view.Image;
    }
}
