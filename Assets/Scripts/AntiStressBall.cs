using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiStressBall : MonoBehaviour
{
    [SerializeField] private Material BallMaterial;


    public void Initialize(Color color, float radio)
    {
        ChangeColor(color);
        ChangeSize(radio);
    }
    public void ChangeColor(Color color)
    {
        BallMaterial.color = color;
    }

    public void ChangeSize(float radius)
    {
        float diameter = radius * 2f;
        gameObject.transform.localScale = new Vector3(diameter, diameter, diameter);
        
        //Stick ball to the ground
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, radius, gameObject.transform.localPosition.z);
    }
}
