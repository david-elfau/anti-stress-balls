using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private BallTypeSelector   TypeSelector;
    [SerializeField] private BallColorSelector  ColorSelector;
    [SerializeField] private BallSizeSelector   SizeSelector;
    [SerializeField] private BallVisor          Visor;

    public void Initialize(DataManager dataManager)
    {
        TypeSelector.Initialize(dataManager.GetListBallTypes());
        ColorSelector.Initialize(dataManager.GetListBallTypes()[0].GetBallColors());
        SizeSelector.Initialize();
        Visor.Initialize();
    }
}
