using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : GenericButton
{
    private BallColor BallColor;

    public void Initizialize(BallColor ballColor)
    {
        BallColor = ballColor;
        UpdateButtonText(BallColor.ColorName);
        this.GetComponent<Image>().color = BallColor.UIColor;
    }

    public override void OnButtonTap()
    {
        Debug.Log("BUTTON " + BallColor.ColorName + " tapped");
        SetSelected(true);
    }

    protected override void UpdateButton()
    {
        throw new System.NotImplementedException();
    }
}
