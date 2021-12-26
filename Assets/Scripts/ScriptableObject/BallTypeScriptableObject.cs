using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallType", menuName = "ScriptableObjects/BallSize", order = 1)]
public class BallTypeScriptableObject : ScriptableObject
{
    public string SizeName;
    public float minRadius,maxRadius;
    public List<IBallColorScriptableObject> PosibleColor = new List<IBallColorScriptableObject>();
}
