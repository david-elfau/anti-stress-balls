using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeButton : GenericButton
{
    private BallType BallType;

    public void Initizialize(BallType ballType)
    {
        BallType = ballType;
        UpdateButtonText(BallType.TypeName);
    }


    public override void OnButtonTap()
    {
        Debug.Log("BUTTON " + BallType.TypeName + " tapped");
        SetSelected(true);
    }



    protected override void UpdateButton()
    {
        throw new System.NotImplementedException();
    }
}
