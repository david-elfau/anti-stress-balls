using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallSize", menuName = "ScriptableObjects/BallSize", order = 1)]
public class BallTypeScriptableObject : ScriptableObject
{
    public string SizeName;
    public float minRadius,maxRadius;
    public List<BallColorScriptableObject> PosibleColor = new List<BallColorScriptableObject>();
}
