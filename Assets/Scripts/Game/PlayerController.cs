using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controller for a player's action during play. Eventually would have been split into AIPlayerController, and HumanPlayerController
/// </summary>
public class PlayerController : SeatController
{
    [SerializeField]
    InputField m_betField = null;

    [SerializeField]
    Button m_placeBetButton = null;

    public bool hasPlacedBet { get; private set; } = false;

    public int currentBet { get; set; } = 0;

    public void PlaceBet(int betAmount)
    {
        currentBet = betAmount;
        hasPlacedBet = true;
    }

    protected void Start()
    {
        m_placeBetButton.onClick.AddListener(PlaceBet);
        m_betField.onEndEdit.AddListener(OnEndEditBet);
    }

    protected void OnDestroy()
    {
        m_placeBetButton.onClick.RemoveListener(PlaceBet);
        m_betField.onEndEdit.RemoveListener(OnEndEditBet);
    }

    private int GetBetFromInput(string input)
    {
        return HelperClasses.SafeParseStringAsInt(input, m_gameMode.minBet);
    }

    private void OnEndEditBet(string newText)
    {
        int betAmount = GetBetFromInput(newText);
        m_betField.text = betAmount.ToString();
    }

    private void PlaceBet()
    {
        int betAmount = GetBetFromInput(m_betField.text);
        if (betAmount >= m_gameMode.minBet)
        {
            currentBet = betAmount;
            hasPlacedBet = true;
        }
    }
}
