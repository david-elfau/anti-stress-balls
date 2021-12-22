using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorSelector : MonoBehaviour
{
    [SerializeField] private GameObject PrefabButton;

    private List<BallColor> ColorList;
    private List<ColorButton> ButtonList;

    private BallColor LastColorSelected = null;
    private BallColor ColorSelected = null;

    public  void Initialize(List<BallColor> existentColors)
    {
        ColorList = existentColors;
        InitializeButtons();
        RegisterEvents();
    }

    private void InitializeButtons()
    {
        ButtonList = new List<ColorButton>();
        foreach (BallColor color in ColorList)
        {
            GameObject newGameObject = Instantiate(PrefabButton, transform);
            ColorButton newButton = newGameObject.GetComponent<ColorButton>();

            newButton.Initizialize(color);
            ButtonList.Add(newButton);
        }
    }

    private void ChangeColorSelected(BallColor newColorSelected)
    {
        LastColorSelected = ColorSelected;
        ColorSelected = newColorSelected;
        //TODO: Repaint;
    }

    private void RegisterEvents()
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
