using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTypeSelector : MonoBehaviour
{
    [SerializeField] private GameObject PrefabButton;

    private List<TypeButton> ButtonList;
    private BallType TypeSelected = null;

    public void Initialize(List<BallType> typeList)
    {
        InitializeButtons(typeList);
    }

    private void InitializeButtons(List<BallType> typeList)
    {
        ButtonList = new List<TypeButton>();
        foreach (BallType type in typeList)
        {
            GameObject newGameObject = Instantiate(PrefabButton, transform);
            TypeButton newButton = newGameObject.GetComponent<TypeButton>();

            newButton.Initizialize(type);
            ButtonList.Add(newButton);
        }


        AutoSelectFirstType();
    }

    private void AutoSelectFirstType()
    {
        ButtonList[0].OnButtonTap();
    }

    public void SelectedType(BallType type)
    {
        if (TypeSelected == null || TypeSelected != type)
        {
            foreach (TypeButton button in ButtonList)
            {
                if (button.BallType == type)
                {
                    TypeSelected = button.BallType;
                    button.SetSelected(true);
                }
                else
                {
                    button.SetSelected(false);
                }
            }
        }
    }
}
