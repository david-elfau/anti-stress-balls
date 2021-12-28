using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorSelector : MonoBehaviour
{
    [SerializeField] private GameObject PrefabButton;

    private List<ColorButton> ButtonList;

    private IBallColor LastColorSelected = null;

    public void Initialize(List<IBallColor> colorsList)
    {
        InitializeButtons(colorsList);
        RegisterEvents();
    }

    private void InitializeButtons(List<IBallColor> colorsList)
    {
        ButtonList = new List<ColorButton>();
        foreach (IBallColor color in colorsList)
        {
            GameObject newGameObject = Instantiate(PrefabButton, transform);
            ColorButton newButton = newGameObject.GetComponent<ColorButton>();

            newButton.Initizialize(color);
            ButtonList.Add(newButton);
        }

        AutoSelectFirstColor();
    }

    public void ReloadButtons(UserChoiceManager UserChoiceManager)
    {
        //Get new colors
        List<IBallColor> colorsList = UserChoiceManager.BallTypeSelected.GetBallColors();

        int differenceSize = ButtonList.Count - colorsList.Count;

        //Remove not needed buttons
        if (differenceSize > 0)
        {
            for (int i = ButtonList.Count - differenceSize; i < ButtonList.Count; i++)
            {
                Destroy(ButtonList[i].gameObject);
            }
            ButtonList.RemoveRange(ButtonList.Count-differenceSize, differenceSize);
        }

        for(int i=0; i<colorsList.Count; i++)
        {
            if(i+1 > ButtonList.Count)
            {
                //Add new button
                GameObject newGameObject = Instantiate(PrefabButton, transform);
                ColorButton newButton = newGameObject.GetComponent<ColorButton>();

                newButton.Initizialize(colorsList[i]);
                ButtonList.Add(newButton);
            }
            else
            {
                //Reuse button
                ButtonList[i].Initizialize(colorsList[i]);
            }
        }

        SetSelectedColor(UserChoiceManager.BallColorSelected);
    }

    public void SetSelectedColor(IBallColor ballColorSelected)
    {
        bool IsColorSelected = false;
        foreach (ColorButton button in ButtonList)
        {
            if (LastColorSelected == null || button.BallColor == ballColorSelected)
            {
                LastColorSelected = ballColorSelected;
                button.SetSelected(true);
                IsColorSelected = true;
            }
            else
            {
                button.SetSelected(false);
            }
        }
        if(!IsColorSelected)
        {
            AutoSelectFirstColor();
        }
        

    }
    
    private void AutoSelectFirstColor()
    {
        if(ButtonList.Count>0)
        {
            ButtonList[0].OnButtonTap();
        }
    }

    private void RegisterEvents()
    {
        EventBus.Instance.StartListening(EventName.ChangeType, OnTypeChange);
    }

    private void OnTypeChange(ParameterBusObject parameters)
    {
    }


    void OnDestroy()
    {
        UnregisterEvents();
    }
    private void UnregisterEvents()
    {
    }
}
