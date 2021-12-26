using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : GenericButton
{
    public BallColor BallColor;

    public void Initizialize(BallColor ballColor)
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
