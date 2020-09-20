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
        return Math.Max(HelperClasses.GetInputFieldValueAsInt(m_minBet.text, m_minBetDefault), 1);
    }

    public int GetStartingCash()
    {
        return Math.Max(HelperClasses.GetInputFieldValueAsInt(m_startingCash.text, m_startingCashDefault), 1);
    }

}
