using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor : IBallColor
{
    public override void Initialize(IBallColorScriptableObject ColorData)
    {
        ColorName = ColorData.ColorName;
        UIColor = ColorData.BallColor;
    }

    public override bool DoOverrideDefaultSize(out float defaultValue)
    {
        defaultValue = float.NaN;
        return false;
    }


}
