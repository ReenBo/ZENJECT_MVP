using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GameObjectView : MonoBehaviour
{
    [SerializeField] Button _buttonPlus;

    [SerializeField] private DataProvider _dataProvider;
    [SerializeField] private DataView _dataView;
    [SerializeField] private GameObject _gameObjectView_1;

    private IView<string, Sprite> _view_1;

    //[Inject]
    //private void Construct(Presenter presenter)
    //{
    //    _buttonPlus.onClick.AddListener(presenter.Incr);
    //    Debug.Log(presenter.Counter);

    //    presenter.onIncremented += locIncr;
    //}

    //private void locIncr(int obj)
    //{
    //    Debug.Log(obj++);
    //}

    private void Start()
    {
        //var gView_1 = _gameObjectView_1.GetComponent<SetupView>();

        //_view_1 = new View<string, Sprite>(
        //    _dataProvider.Summary, 
        //    _dataProvider.Sprite);

        //gView_1.Init(_view_1.Summary, _view_1.Image);
    }
}
