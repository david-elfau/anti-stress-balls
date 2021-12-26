using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<BallTypeScriptableObject> DataInput;

    private Dictionary<string, IBallColor> ExistentColors;
    private List<BallType> ExistentTypes;


    public void Initialize()
    {
        ExistentColors = new Dictionary<string, IBallColor>();
        ExistentTypes = new List<BallType>();
        foreach(BallTypeScriptableObject typeData in DataInput)
        {
            foreach (IBallColorScriptableObject colorData in typeData.PosibleColor)
            {
                CreateBallColor(colorData);
            }
            
            BallType ballType = new BallType();
            ballType.Initialize(typeData, ExistentColors);
            ExistentTypes.Add(ballType);
        }
    }

    private void CreateBallColor(IBallColorScriptableObject colorData)
    {
        if (!ExistentColors.ContainsKey(colorData.ColorName))
        {
            IBallColor ballColor;

            if (colorData is BallColorOverrideSizeScriptableObject)
            {
                ballColor = new BallColorOverridesSize();
            }
            else
            {
                ballColor = new BallColor();
            }
            ballColor.Initialize(colorData);
            ExistentColors.Add(colorData.ColorName, ballColor);
        }
    }

    public List<BallType>  GetListBallTypes()
    {
        return ExistentTypes;
    }
    public Dictionary<string, IBallColor> GetAllColors()
    {
        return ExistentColors;
    }

}
