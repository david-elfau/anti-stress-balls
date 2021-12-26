using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterBusObject
{
    object parameterValue = null;
    // Start is called before the first frame update

    public ParameterBusObject()
    {

    }

    public ParameterBusObject(string stringParameter)
    {
        parameterValue = stringParameter;
    }
    public ParameterBusObject(int intParameter)
    {
        parameterValue = intParameter;

    }
    public ParameterBusObject(float floatParameter)
    {
        parameterValue = floatParameter;
    }
    public ParameterBusObject(bool boolParameter)
    {
        parameterValue = boolParameter;
    }


    public string GetParameterString()
    {
        return parameterValue.ToString();
    }

    public int GetParameterInt()
    {
        try
        {
            int intValue = (int)parameterValue;
            return intValue;
        }
        catch (Exception)
        {
            return int.MinValue;
        }
    }

    public float GetParameterFloat()
    {
        try
        {
            float floatValue = (float)parameterValue;
            return floatValue;
        }
        catch (Exception)
        {
            return float.MinValue;
        }
    }

    public bool GetParameterBool()
    {
        try
        {
            bool boolValue = (bool)parameterValue;
            return boolValue;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
