using UnityEngine;
using System;
using System.Collections;

public class View<T, P> : IView<T, P>
{
    private T _summary;
    private P _image;

    public View(T summary, P image)
    {
        _summary = summary;
        _image = image;
    }

    public T Summary => _summary;
    public P Image => _image;
}