using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorOverridesSize : IBallColor
{
    public float OverrideSizeValue;

    public override void Initialize(IBallColorScriptableObject ColorData)
    {
        ColorName = ColorData.ColorName;
        UIColor = ColorData.BallColor;

        if(ColorData is BallColorOverrideSizeScriptableObject)
        {
            OverrideSizeValue = ((BallColorOverrideSizeScriptableObject)ColorData).OverrideSizeValue;
        }
    }


    public override bool DoOverrideDefaultSize(out float defaultValue)
    {
        defaultValue = OverrideSizeValue;
        return true;
    }

}
