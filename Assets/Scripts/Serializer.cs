using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// Serializer I found online to get the saving job done for now. This is nicer than PlayerPrefs because it can save more complex serializable C# classes.
/// </summary>
public class Serializer
{
    public static T Load<T>(string filePath) where T : class
    {
        if (File.Exists(filePath))
        {
            try
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return formatter.Deserialize(stream) as T;
                }
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
        return default(T);
    }

    public static void Save<T>(string filePath, T data) where T : class
    {
        using (Stream stream = File.OpenWrite(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
        }
    }
}