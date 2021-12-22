using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorSelector : MonoBehaviour
{
    private BallColor LastColorSelected = null;
    private BallColor ColorSelected = null;

    public  void Initialize(List<BallColor> existentColors)
    {

    }

    private void ChangeColorSelected(BallColor newColorSelected)
    {
        LastColorSelected = ColorSelected;
        ColorSelected = newColorSelected;
        //TODO: Repaint;
    }
}
