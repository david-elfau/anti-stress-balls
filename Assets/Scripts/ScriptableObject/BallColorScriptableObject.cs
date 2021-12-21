using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallColor", menuName = "ScriptableObjects/BallColor", order = 2)]
public class BallColorScriptableObject : ScriptableObject
{
    public string ColorName;
    public Color BallColor;
}
