using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor : MonoBehaviour
{
    public string ColorName;
    public Color UIColor;

    public void Initialize(BallColorScriptableObject ColorData)
    {
        ColorName = ColorData.ColorName;
        UIColor = ColorData.BallColor;
    }

}
