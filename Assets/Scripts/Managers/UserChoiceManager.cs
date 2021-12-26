using System;
using UnityEngine;

public class UserChoiceManager : MonoBehaviour
{
    public BallType BallTypeSelected = null;
    public BallColor BallColorSelected = null;
    public float BallSizeSelected = 1;
    public float SizeStep = 0.1f;


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

        PlaceSizeOnBounds();
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

        PlaceSizeOnBounds();
    }
    public void OnBallSizeChange(ParameterBusObject parameters)
    {
        bool changeIsIncrease = parameters.GetParameterBool();
        ChangeBallSize(changeIsIncrease);
    }

    private void ChangeBallSize(bool increase)
    {
        if (!BallColorSelected.OverridesDefaultSize)
        {
            float sizeCandidate = BallSizeSelected;
            if (increase)
            {
                sizeCandidate += SizeStep;
            }
            else
            {
                sizeCandidate -= SizeStep;
            }

            BallSizeSelected = Mathf.Clamp(sizeCandidate, BallTypeSelected.minRadius, BallTypeSelected.maxRadius);

        }
    }

    private void PlaceSizeOnBounds()
    {
        if (BallColorSelected != null && BallColorSelected.OverridesDefaultSize)
        {
            BallSizeSelected = BallColorSelected.OverrideSizeValue;
        }
        else
        {
            BallSizeSelected = Mathf.Clamp(BallSizeSelected, BallTypeSelected.minRadius, BallTypeSelected.maxRadius);
        }

    }

}