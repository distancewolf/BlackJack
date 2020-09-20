using UnityEngine;

/// <summary>
/// Controls play at a table of Black Jack
/// </summary>
public class TableController : MonoBehaviour
{
    [SerializeField]
    DealerController m_dealer = null;

    [SerializeField]
    PlayerController m_player = null; //TODO: add ability for more players

    [SerializeField]
    BetController m_betController = null;

    [SerializeField]
    PlayerTableAreaView m_playerTableArea = null;

    private BlackJackGameMode m_gameMode;
    private BlackJackGameState m_gameState;

    protected void Start()
    {
        BlackJackGameMode gameMode = BlackJackGame.Get().gameMode;

        m_gameState = new BlackJackGameState(gameMode.numDecks);

        m_dealer.Initialize(gameMode, m_gameState);
        m_player.Initialize(gameMode, m_gameState);
    }

    void Update()
    {
        switch (m_gameState.currentPhase)
        {
            case EGamePhase.PlacingBets:
                UpdateBet();
                break;
            case EGamePhase.ReceivingCards:
                UpdateDealCards();
                break;
            case EGamePhase.Action:
                UpdateAction();
                break;
            case EGamePhase.BetsResolving:

                break;
        }
    }

    private void UpdateBet()
    {
        ShowBetUI(true);

        if (m_player.hasPlacedBet)
        {
            InitializeDealCards();
        }

    }

    private void ShowBetUI(bool show)
    {
        if (m_betController.gameObject.activeSelf != show)
        {
            m_betController.gameObject.SetActive(show);
        }
    }

    private void InitializeDealCards()
    {
        ShowBetUI(false);
        m_gameState.currentPhase = EGamePhase.ReceivingCards;
    }

    private void UpdateDealCards()
    {

    }

    private void UpdateAction()
    {
    }

    private void ShowActionUI()
    {
    }

    private void ShowWaitingUI()
    {
    }

}
