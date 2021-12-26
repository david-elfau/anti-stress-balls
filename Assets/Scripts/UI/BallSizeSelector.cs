using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallSizeSelector : MonoBehaviour
{
    [SerializeField] private ChangeSizeButton IncreaseButton;
    [SerializeField] private ChangeSizeButton DecreaseButton;
    [SerializeField] protected TextMeshProUGUI CounterText;

    public void Initialize(UserChoiceManager userChoiceManager)
    {
        IncreaseButton.Initizialize(true);
        DecreaseButton.Initizialize(false);

        UpdateCounterValue(userChoiceManager);
        UpdateVisibilityButtons(userChoiceManager);
    }

    void OnDestroy()
    {
    }

    void UpdateVisibilityButtons(UserChoiceManager userChoiceManager)
    {
        if (userChoiceManager.BallTypeSelected != null && userChoiceManager.BallColorSelected != null)
        {
            float overrideSize;

            if (userChoiceManager.BallColorSelected.DoOverrideDefaultSize(out overrideSize))
            {
                IncreaseButton.gameObject.SetActive(false);
                DecreaseButton.gameObject.SetActive(false);
            }
            else
            {
                if (userChoiceManager.BallSizeSelected >= userChoiceManager.BallTypeSelected.maxRadius)
                {
                    IncreaseButton.gameObject.SetActive(false);
                    DecreaseButton.gameObject.SetActive(true);

                }
                else if (userChoiceManager.BallSizeSelected <= userChoiceManager.BallTypeSelected.minRadius)
                {
                    IncreaseButton.gameObject.SetActive(true);
                    DecreaseButton.gameObject.SetActive(false);
                }
                else
                {
                    IncreaseButton.gameObject.SetActive(true);
                    DecreaseButton.gameObject.SetActive(true);
                }
            }
        }
    }

    void UpdateCounterValue(UserChoiceManager userChoiceManager)
    {
        CounterText.text = Math.Round(userChoiceManager.BallSizeSelected, 1).ToString();
    }

    public void RefreshData(UserChoiceManager userChoiceManager)
    {
        UpdateVisibilityButtons(userChoiceManager);
        UpdateCounterValue(userChoiceManager);
    }
}
