using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSizeSelector : IUIPanel
{
    public void Initialize()
    {
        RegisterEvents();
    }
    void OnDestroy()
    {
        UnregisterEvents();
    }

    public override void RegisterEvents()
    {
        throw new NotImplementedException();
    }

    public override void UnregisterEvents()
    {
        throw new NotImplementedException();
    }

    public override void UpdateContent()
    {
        throw new NotImplementedException();
    }
}
