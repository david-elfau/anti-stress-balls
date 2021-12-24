using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeButton : GenericButton
{
    public BallType BallType;

    public void Initizialize(BallType ballType)
    {
        BallType = ballType;
        UpdateButtonText(BallType.TypeName);
    }


    public override void OnButtonTap()
    {
        Debug.Log("BUTTON " + BallType.TypeName + " tapped");
        EventBus.Instance.TriggerEvent(EventName.ChangeType, new ParameterBusObject(BallType.TypeName));
    }
}
