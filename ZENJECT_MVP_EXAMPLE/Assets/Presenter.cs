using System;
using System.Collections.Generic;
using Zenject;

public class Presenter : IPresenter, IInitializable
{
    private IVView _view;

    public Presenter(IVView view)
    {
        _view = view;
    }

    public void Initialize()
    {
        _view.Text.text = "Hello Zenject!";
    }
}
