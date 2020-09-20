using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGamePopupController : MonoBehaviour
{

    [SerializeField]
    private InputField m_minBet = null;

    [SerializeField]
    private InputField m_startingCash = null;

    [SerializeField]
    private int m_minBetDefault = 10;

    [SerializeField]
    private int m_startingCashDefault = 100;

    protected void Awake()
    {
        m_minBet.text = m_minBetDefault.ToString();
        m_startingCash.text = m_startingCashDefault.ToString();
    }

    public int GetMinBet()
    {
        return Math.Max(GetInputFieldValueAsInt(m_minBet, m_minBetDefault), 1);
    }

    public int GetStartingCash()
    {
        return Math.Max(GetInputFieldValueAsInt(m_startingCash, m_startingCashDefault), 1);
    }

    public int GetInputFieldValueAsInt(InputField inputField, int defaultValue)
    {
        //should succeed, since InputField is set to be integer only, but use Try/Catch to be safe
        try
        {
            return Int32.Parse(inputField.text);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }

        return defaultValue;
    }
}
