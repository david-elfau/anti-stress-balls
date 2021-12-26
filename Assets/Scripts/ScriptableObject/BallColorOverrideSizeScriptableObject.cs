using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallColorOverrideSize", menuName = "ScriptableObjects/BallColorOverrideSize", order = 3)]
public class BallColorOverrideSizeScriptableObject : IBallColorScriptableObject
{
    public float OverrideSizeValue = 0;
}
