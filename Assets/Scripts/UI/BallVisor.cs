using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVisor : MonoBehaviour
{
    [SerializeField] private AntiStressBall Ball;
    [SerializeField] private CameraController Camera;
    public void Initialize(UserChoiceManager userChoiceManager)
    {
        ReloadVisor(userChoiceManager);
    }

    public void ReloadVisor(UserChoiceManager userChoice)
    {
        Ball.ChangeColor(userChoice.BallColorSelected.UIColor);
        Ball.ChangeSize(userChoice.BallSizeSelected);
        Camera.PointTo(Ball.transform.position+new Vector3(0,userChoice.BallSizeSelected,0));
    }
}
