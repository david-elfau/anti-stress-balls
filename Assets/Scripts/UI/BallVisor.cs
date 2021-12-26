using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVisor : MonoBehaviour
{
    [SerializeField] private AntiStressBall Ball;
    public void Initialize(UserChoiceManager userChoiceManager)
    {
    }
    void OnDestroy()
    {
    }

    public void ReloadVisor(UserChoiceManager userChoice)
    {
        Ball.ChangeColor(userChoice.BallColorSelected.UIColor);
        Ball.ChangeSize(userChoice.BallSizeSelected);

    }
}
