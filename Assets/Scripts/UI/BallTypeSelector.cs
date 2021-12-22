using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTypeSelector : MonoBehaviour
{
    [SerializeField] private GameObject PrefabButton;

    private List<BallType> TypeList;
    private List<BallTypeButton> ButtonList;
    private BallType TypeSelected = null;
    
    public void Initialize(List<BallType> existentTypes)
    {
        this.TypeList = existentTypes;
        InitializeButtons();
    }

    private void InitializeButtons()
    {
        ButtonList = new List<BallTypeButton>();
        foreach (BallType type in TypeList)
        {
            GameObject newGameObject = Instantiate(PrefabButton, transform);
            BallTypeButton newButton = newGameObject.GetComponent<BallTypeButton>();

            newButton.Initizialize(type);
            ButtonList.Add(newButton);
        }

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

    public void UpdateButtonsStatus()
    {
        //TODO Recorrer el listado de botones y activarlos y desactivarlos 
    }


}
