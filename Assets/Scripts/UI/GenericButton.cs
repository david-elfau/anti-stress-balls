using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class GenericButton : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI ButtonText;
    protected bool IsSelected = false;

    protected void UpdateButtonText(string text)
    {
        ButtonText.text = text;
    }

    public void SetSelected(bool isSelected)
    {
        bool oldStatus = IsSelected;
        IsSelected = isSelected;

        if (oldStatus != IsSelected)
        {
            UpdateButton();
        }
    }
    protected abstract void UpdateButton();

    public abstract void OnButtonTap();

}
