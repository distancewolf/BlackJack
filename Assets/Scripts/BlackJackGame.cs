using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The only singleton allowed. This can store any persistent data/controllers required.
/// </summary>
public class BlackJackGame : MonoBehaviour
{
    #region singleton members
    private static BlackJackGame m_instance;

    public static BlackJackGame Get()
    {
        if (m_instance == null)
        {
            Debug.LogWarning("You are trying to access BlackJackGame before it has been initialized!");
        }

        return m_instance;
    }

    protected void Awake()
    {
        if (m_instance != null)
        {
            Debug.LogWarning("You are trying to create another BlackJackGame object, this is not allowed");
        }

        m_instance = this;
        DontDestroyOnLoad(this);
    }
    #endregion

    public BlackJackSaveState saveState { get; private set; } = null;

    public BlackJackGameMode gameMode { get; private set; } = null;
    

    public void LoadContent()
    {
        saveState = Serializer.Load<BlackJackSaveState>(UnityEngine.Application.persistentDataPath + Constants.c_saveStateFileName);
    }

    public void CreateNewGameMode(int minBet, int startingCash)
    {
        gameMode = new BlackJackGameMode(minBet, startingCash);
    }

}
