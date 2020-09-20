using System;
using UnityEngine;
using UnityEngine.UI;

public class HelperClasses
{
    /// <summary>
    /// Parses a string input field to an int.
    /// </summary>
    /// <param name="inputText"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public static int SafeParseStringAsInt(string inputText, int defaultValue)
    {
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
