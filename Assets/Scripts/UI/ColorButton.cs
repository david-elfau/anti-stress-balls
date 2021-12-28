using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : IButton
{
    public IBallColor BallColor;
    [SerializeField] private Material SpriteOutlineMaterialON;
    [SerializeField] private Material SpriteOutlineMaterialOFF;

    public void Initizialize(IBallColor ballColor)
    {
        BallColor = ballColor;
        UpdateButtonText(BallColor.ColorName);
        this.GetComponent<Image>().color = BallColor.UIColor;
        SetSelected(false);
    }

    public override void OnButtonTap()
    {
        EventBus.Instance.TriggerEvent(EventName.ChangeColor, new ParameterBusObject(BallColor.ColorName));
    }

    public override void UpdateStatus()
    {
        if (IsSelected)
        {
            gameObject.GetComponent<Image>().material = SpriteOutlineMaterialON;
        }
        else
        {
            gameObject.GetComponent<Image>().material = SpriteOutlineMaterialOFF;
        }
    }
}
