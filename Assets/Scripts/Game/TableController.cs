using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    [SerializeField]
    DealerController m_dealer;

    
    [SerializeField]
    PlayerController m_player; //TODO: add ability for more players

    private BlackJackGameMode m_gameMode;

    private BlackJackGameState m_gameState;

    // Start is called before the first frame update
    void Start()
    {
        BlackJackGameMode gameMode = BlackJackGame.Get().gameMode;
        m_gameState = new BlackJackGameState();

        m_dealer.Initialize(gameMode, m_gameState);
        m_player.Initialize(gameMode, m_gameState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
