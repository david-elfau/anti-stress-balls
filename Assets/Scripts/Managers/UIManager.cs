using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private BallTypeSelector   TypeSelector;
    [SerializeField] private BallColorSelector  ColorSelector;
    [SerializeField] private BallSizeSelector   SizeSelector;
    [SerializeField] private BallVisor          Visor;

    UserChoiceManager UserChoiceManager;

    public void Initialize(DataManager dataManager, UserChoiceManager userChoiceManager)
    {
        UserChoiceManager = userChoiceManager;
        TypeSelector.Initialize(dataManager.GetListBallTypes());
        ColorSelector.Initialize(dataManager.GetListBallTypes()[0].GetBallColors());
        SizeSelector.Initialize();
        Visor.Initialize();

        RegisterEvents();
    }

    void OnDestroy()
    {
        UnregisterEvents();
    }
    public void RegisterEvents()
    {
        EventBus.Instance.StartListening(EventName.ChangeType, OnBallTypeChange);
        EventBus.Instance.StartListening(EventName.ChangeColor, OnBallColorChange);
        EventBus.Instance.StartListening(EventName.ChangeSize, OnBallSizeChange);
    }

    public void UnregisterEvents()
    {
        EventBus.Instance.StopListening(EventName.ChangeType, OnBallTypeChange);
        EventBus.Instance.StopListening(EventName.ChangeColor, OnBallColorChange);
        EventBus.Instance.StopListening(EventName.ChangeSize, OnBallSizeChange);
    }

    public void OnBallTypeChange(ParameterBusObject parameters)
    {
        UserChoiceManager.OnBallTypeChange(parameters);
        TypeSelector.SelectedType(UserChoiceManager.BallTypeSelected);
        ColorSelector.ReloadButtons(UserChoiceManager);
        Visor.ReloadVisor(UserChoiceManager);

    }

    public void OnBallColorChange(ParameterBusObject parameters)
    {
        UserChoiceManager.OnBallColorChange(parameters);
        Visor.ReloadVisor(UserChoiceManager);

    }
    public void OnBallSizeChange(ParameterBusObject parameters)
    {
        UserChoiceManager.OnBallSizeChange(parameters);
        Visor.ReloadVisor(UserChoiceManager);

    }

}
