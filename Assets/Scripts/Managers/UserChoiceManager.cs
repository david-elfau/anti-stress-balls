using System;
using UnityEngine;

public class UserChoiceManager : MonoBehaviour
{
    public BallType BallTypeSelected = null;
    public BallColor BallColorSelected = null;
    public float BallSizeSelected = 0;

    DataManager DataManager;


    public void Initialize(DataManager dataManager)
    {
        this.DataManager = dataManager;
    }


}