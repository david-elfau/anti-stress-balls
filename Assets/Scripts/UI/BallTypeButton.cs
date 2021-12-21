using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallTypeButton : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI SizeNameText;
    private BallSizeScriptableObject BallSizeData;

    public void Initizialize(BallSizeScriptableObject ballSizeData )
    {
        BallSizeData = ballSizeData;
        UpdateButtonText();
    }

    private void UpdateButtonText()
    {
        SizeNameText.text = BallSizeData.name;
    }

    public void OnButtonTap()
    {
        Debug.Log("BUTTON " + BallSizeData.name + " tapped");
    }

}
