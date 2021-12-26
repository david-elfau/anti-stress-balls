using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeButton : IButton
{
    public BallType BallType;

    public void Initizialize(BallType ballType)
    {
        BallType = ballType;
        UpdateButtonText(BallType.TypeName);
    }


    public override void OnButtonTap()
    {
        EventBus.Instance.TriggerEvent(EventName.ChangeType, new ParameterBusObject(BallType.TypeName));
    }
}
