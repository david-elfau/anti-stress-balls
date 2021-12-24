using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    [SerializeField] private DataManager DataManager;
    [SerializeField] private UIManager UImanager;
    [SerializeField] private UserChoiceManager UserChoiceManager;
 

    public void Awake()
    {
        Initialize();
    }

    public void Initialize()
    {
        EventBus bus = EventBus.Instance;
        DataManager.Initialize();
        UserChoiceManager.Initialize(DataManager);

        UImanager.Initialize(DataManager, UserChoiceManager);
    }

}
