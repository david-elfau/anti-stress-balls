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
        DataManager.Initialize();
        UImanager.Initialize(DataManager);
        UserChoiceManager.Initialize(DataManager);
    }

}
