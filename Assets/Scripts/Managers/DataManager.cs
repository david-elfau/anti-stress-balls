using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<BallTypeScriptableObject> DataInput;

    private Dictionary<string, BallColor> ExistentColors;
    private List<BallType> ExistentTypes;


    public void Initialize()
    {
        ExistentColors = new Dictionary<string, BallColor>();
        ExistentTypes = new List<BallType>();

        foreach(BallTypeScriptableObject typeData in DataInput)
        {
            foreach(BallColorScriptableObject colorData in typeData.PosibleColor)
            {
                CreateBallColor(colorData);
            }
            
            BallType ballType = new BallType();
            ballType.Initialize(typeData, ExistentColors);
            ExistentTypes.Add(ballType);
        }
    }

    private void CreateBallColor(BallColorScriptableObject colorData)
    {
        if (!ExistentColors.ContainsKey(colorData.ColorName))
        {
            BallColor ballColor = new BallColor();
            ballColor.Initialize(colorData);
            ExistentColors.Add(colorData.ColorName, ballColor);
        }
    }

    public List<BallType>  GetListBallTypes()
    {
        return ExistentTypes;
    }
    public Dictionary<string, BallColor> GetAllColors()
    {
        return ExistentColors;
    }

}
