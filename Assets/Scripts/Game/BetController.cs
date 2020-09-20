using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// manages betting for the player
/// </summary>
public class BetController : MonoBehaviour
{
    [SerializeField]
    InputField m_inputField = null;

    private BlackJackGameMode m_gameMode;

    public void Initialize(BlackJackGameMode gameMode)
    {
        InitializeInputField();
    }

    protected void OnEnable()
    {
        InitializeInputField();
    }

    private void InitializeInputField()
    {
        if (m_gameMode != null)
        {
            m_inputField.text = m_gameMode.minBet.ToString();
        }
    }
}
