using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypeButton : IButton
{
    public BallType BallType;
    [SerializeField] private Material SpriteOutlineMaterialON;
    [SerializeField] private Material SpriteOutlineMaterialOFF;

    public void Initizialize(BallType ballType)
    {
        BallType = ballType;
        UpdateButtonText(BallType.TypeName);

        ChangeMaterial();
    }


    public override void OnButtonTap()
    {
        EventBus.Instance.TriggerEvent(EventName.ChangeType, new ParameterBusObject(BallType.TypeName));
    }

    private void ChangeMaterial()
    {
        if (IsSelected)
        {
            gameObject.GetComponent<Image>().material = SpriteOutlineMaterialON;
        }
        else
        {
            gameObject.GetComponent<Image>().material = SpriteOutlineMaterialOFF;
        }
    }
}
