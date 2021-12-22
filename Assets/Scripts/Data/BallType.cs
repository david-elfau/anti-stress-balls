using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallType
{
    public string TypeName;
    private List<BallColor> PossibleColors;

    public void Initialize(BallTypeScriptableObject TypeData, Dictionary<string,BallColor> ExistentColors)
    {
        PossibleColors = new List<BallColor>();
        TypeName = TypeData.name;

        foreach(BallColorScriptableObject ballColorSO in TypeData.PosibleColor)
        {
            BallColor ballColor =null;
            ExistentColors.TryGetValue(ballColorSO.name, out ballColor);
            if (ballColor != null )
            {
                PossibleColors.Add(ballColor);
            }
        }
    }
    public List<BallColor> GetBallColors()
    {
        return PossibleColors;
    }


}