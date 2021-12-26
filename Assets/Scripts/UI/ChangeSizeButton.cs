using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeSizeButton : GenericButton
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
        if (IncreasesValue)
        {

            Debug.Log("INCREASE VALUE");
        }
        else
        {
            Debug.Log("DECREASE VALUE");

        }
        EventBus.Instance.TriggerEvent(EventName.ChangeSize, new ParameterBusObject(IncreasesValue));
    }
}
