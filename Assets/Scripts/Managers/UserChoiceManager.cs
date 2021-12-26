using System;
using UnityEngine;

public class UserChoiceManager : MonoBehaviour
{
    public BallType BallTypeSelected = null;
    public IBallColor BallColorSelected = null;
    public float BallSizeSelected = 1;
    public const float SizeStep = 0.1f;


    DataManager DataManager;


    public void Initialize(DataManager dataManager)
    {
        this.DataManager = dataManager;
        SetDefaultValues();
    }

    private void SetDefaultValues()
    {
        BallTypeSelected = DataManager.GetListBallTypes()[0];
        BallColorSelected = BallTypeSelected.GetBallColors()[0];
        BallSizeSelected = BallTypeSelected.minRadius;
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

        foreach (IBallColor color in BallTypeSelected.GetBallColors())
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

        float overrideSize;

        if (!BallColorSelected.DoOverrideDefaultSize(out overrideSize))
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
        float overrideSize;

        if (BallColorSelected != null && BallColorSelected.DoOverrideDefaultSize(out overrideSize))
        {
            BallSizeSelected = overrideSize;
        }
        else
        {
            BallSizeSelected = Mathf.Clamp(BallSizeSelected, BallTypeSelected.minRadius, BallTypeSelected.maxRadius);
        }

    }

}