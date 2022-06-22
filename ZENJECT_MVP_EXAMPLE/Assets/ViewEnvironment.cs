using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

class ViewEnvironment : MonoBehaviour, IVView
{
    private Presenter _presenter;

    [SerializeField] private Text _text;
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;

    public Text Text { get => _text; set => _text = value; }
    public Image Image { get => _image; set => _image = value; }
    public Button Button { get => _button; set => _button = value; }

    //[Inject]
    //private void Construct(Presenter presenter)
    //{
    //    _presenter = presenter;
    //}

    protected void Awake()
    {
        _presenter = new Presenter(this);
        _presenter.Initialize();
    }
}
