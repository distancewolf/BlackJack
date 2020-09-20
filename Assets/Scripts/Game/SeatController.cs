using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatController : MonoBehaviour
{
    private BlackJackGameMode m_gameMode; //players keep a pointer to the game mode to help dicate rules
    private BlackJackGameState m_gameState; //players keep a pointer to game state to drive actions.

    public int currentCash { get; set; } = 0;

    public virtual void Initialize(BlackJackGameMode gameMode, BlackJackGameState gameState)
    {
        m_gameMode = gameMode;
        m_gameState = gameState;

        currentCash = gameMode.startingCash;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
