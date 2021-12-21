using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private BallTypeSelector   TypeSelector;
    [SerializeField] private BallColorSelector  ColorSelector;
    [SerializeField] private BallSizeSelector   SizeSelector;
    [SerializeField] private BallVisor          Visor;

    public void Initialize()
    {
        TypeSelector.Initialize();
        ColorSelector.Initialize();
        SizeSelector.Initialize();
        Visor.Initialize();
    }
}
