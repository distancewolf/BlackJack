﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatController : MonoBehaviour
{
    protected BlackJackGameMode m_gameMode; //players keep a pointer to the game mode to help dicate rules
    protected BlackJackGameState m_gameState; //players keep a pointer to game state to drive actions.

    public int currentCash { get; set; } = 0;

    public virtual void Initialize(BlackJackGameMode gameMode, BlackJackGameState gameState)
    {
        m_gameMode = gameMode;
        m_gameState = gameState;

        currentCash = gameMode.startingCash;
    }

}
