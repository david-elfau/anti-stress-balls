using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : IButton
{
    public IBallColor BallColor;

    public void Initizialize(IBallColor ballColor)
    {
        BallColor = ballColor;
        UpdateButtonText(BallColor.ColorName);
        this.GetComponent<Image>().color = BallColor.UIColor;
    }

    public override void OnButtonTap()
    {
        EventBus.Instance.TriggerEvent(EventName.ChangeColor, new ParameterBusObject(BallColor.ColorName));
    }

}
