using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTypes : MonoBehaviour
{
    string TypeName;
    List<BallColor> PossibleColors;

    public void Initialize(BallSizeScriptableObject TypeData, Dictionary<string,BallColor> ExistentColors)
    {
        PossibleColors = new List<BallColor>();
        TypeName = TypeData.name;

        foreach(BallColorScriptableObject ballColorSO in TypeData.PosibleColor)
        {
            BallColor ballColor =null;
            ExistentColors.TryGetValue(ballColorSO.name, out ballColor);
            if (ballColor)
            {
                PossibleColors.Add(ballColor);
            }
        }
    }

}
