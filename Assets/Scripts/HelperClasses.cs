using System;
using UnityEngine;
using UnityEngine.UI;

public class HelperClasses
{
    public static int GetInputFieldValueAsInt(string inputText, int defaultValue)
    {
        //should succeed, since InputFields are set to be integer only, but use Try/Catch to be safe
        try
        {
            return Int32.Parse(inputText);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }

        return defaultValue;
    }
}
