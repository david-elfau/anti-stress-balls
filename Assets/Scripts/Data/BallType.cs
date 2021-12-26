using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallType
{
    public string TypeName;
    private List<IBallColor> PossibleColors;
    public float minRadius, maxRadius;

    public void Initialize(BallTypeScriptableObject TypeData, Dictionary<string,IBallColor> ExistentColors)
    {
        PossibleColors = new List<IBallColor>();
        TypeName = TypeData.SizeName;
        minRadius = TypeData.minRadius;
        maxRadius = TypeData.maxRadius;

        foreach (IBallColorScriptableObject ballColorSO in TypeData.PosibleColor)
        {
            IBallColor ballColor =null;
            ExistentColors.TryGetValue(ballColorSO.ColorName, out ballColor);
            if (ballColor != null )
            {
                PossibleColors.Add(ballColor);
            }
        }
    }
    public List<IBallColor> GetBallColors()
    {
        return PossibleColors;
    }


}
