using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor
{
    public string ColorName;
    public Color UIColor;
    public bool OverridesDefaultSize = false;
    public float OverrideSizeValue;

    public void Initialize(BallColorScriptableObject ColorData)
    {
        ColorName = ColorData.ColorName;
        UIColor = ColorData.BallColor;
        OverridesDefaultSize = ColorData.OverridesDefaultSize;
        OverrideSizeValue = ColorData.OverrideSizeValue;
    }

}
