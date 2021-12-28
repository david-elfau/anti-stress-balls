using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class IButton : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI ButtonText;
    protected bool IsSelected = false;

    protected void UpdateButtonText(string text)
    {
        ButtonText.text = text;
    }

    public void SetSelected(bool isSelected)
    {
        IsSelected = isSelected;
        UpdateStatus();
    }

    public abstract void UpdateStatus();

    public abstract void OnButtonTap();

}
