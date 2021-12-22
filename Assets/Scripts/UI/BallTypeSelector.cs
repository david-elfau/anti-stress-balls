using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTypeSelector : IUIPanel
{
    [SerializeField] private GameObject PrefabButton;

    private List<BallType> TypeList;
    private List<TypeButton> ButtonList;
    private BallType TypeSelected = null;
    
    public void Initialize(List<BallType> existentTypes)
    {
        this.TypeList = existentTypes;
        InitializeButtons();
        RegisterEvents();
    }

    private void InitializeButtons()
    {
        ButtonList = new List<TypeButton>();
        foreach (BallType type in TypeList)
        {
            GameObject newGameObject = Instantiate(PrefabButton, transform);
            TypeButton newButton = newGameObject.GetComponent<TypeButton>();

            newButton.Initizialize(type);
            ButtonList.Add(newButton);
        }
    }

    void OnDestroy()
    {
        UnregisterEvents();
    }
    public override void RegisterEvents()
    {
    }

    public override void UnregisterEvents()
    {
    }



    public void SelectType(string typeName)
    {
        foreach(BallType type in TypeList)
        {
            if(type.TypeName == typeName)
            {
                SelectType(type);
                break;
            }
        }
    }

    public void SelectType(BallType newTypeSelected)
    {
        TypeSelected = newTypeSelected;
    }

    public override void UpdateContent()
    {
        throw new NotImplementedException();
    }
}
