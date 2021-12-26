using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IBallColor
{
    public string ColorName;
    public Color UIColor;

    public abstract bool DoOverrideDefaultSize(out float defaultValue);
    public abstract void Initialize(IBallColorScriptableObject ColorData);
}
