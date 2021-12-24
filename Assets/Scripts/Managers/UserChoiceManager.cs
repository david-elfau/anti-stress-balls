using System;
using UnityEngine;

public class UserChoiceManager : MonoBehaviour
{
    public BallType BallTypeSelected = null;
    public BallColor BallColorSelected = null;
    public float BallSizeSelected = 1;

    DataManager DataManager;


    public void Initialize(DataManager dataManager)
    {
        this.DataManager = dataManager;
    }

    void OnDestroy()
    {
    }


    public void OnBallTypeChange(ParameterBusObject parameters)
    {
        string typeName = parameters.GetParameterString();

        foreach (BallType type in DataManager.GetListBallTypes())
        {
            if (type.TypeName == typeName)
            {
                BallTypeSelected = type;
                break;
            }
        }
    }

    public void OnBallColorChange(ParameterBusObject parameters)
    {
        string colorName = parameters.GetParameterString();
        BallSizeSelected = 1;

        foreach (BallColor color in BallTypeSelected.GetBallColors())
        {
            if (color.ColorName == colorName)
            {
                BallColorSelected = color;
                break;
            }
        }

    }
    public void OnBallSizeChange(ParameterBusObject parameters)
    {

    }

}