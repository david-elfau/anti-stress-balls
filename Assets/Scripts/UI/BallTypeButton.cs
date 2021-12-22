using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallTypeButton : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI SizeNameText;
    private BallType BallType;
    private bool IsSelected = false;

    public void Initizialize(BallType ballType )
    {
        BallType = ballType;
        UpdateButtonText();
    }

    private void UpdateButtonText()
    {
        SizeNameText.text = BallType.TypeName;
    }

    public void OnButtonTap()
    {
        Debug.Log("BUTTON " + BallType.TypeName + " tapped");
    }

    public void SetSelected(bool isSelected)
    {
        bool oldStatus = IsSelected;
        IsSelected = isSelected;

        if(oldStatus != IsSelected)
        {
            UpdateButton();
        }
    }

    public void UpdateButton()
    {
        //TODO change status of the button
        
    }
}
