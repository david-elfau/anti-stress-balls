using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeSizeButton : IButton
{
    public bool IncreasesValue = true;

    public void Initizialize(bool increasesValue)
    {
        this.IncreasesValue = increasesValue;

        if (IncreasesValue)
        {
            UpdateButtonText("+");
        }
        else
        {
            UpdateButtonText("-");
        }
    }

    public override void OnButtonTap()
    {
        EventBus.Instance.TriggerEvent(EventName.ChangeSize, new ParameterBusObject(IncreasesValue));
    }
}
