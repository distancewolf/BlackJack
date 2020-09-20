using UnityEngine;

/// <summary>
/// visual container for a single player's play area
/// </summary>
public class PlayerTableAreaView : MonoBehaviour
{
    [SerializeField]
    private Transform m_startingCardLocation = null;

    [SerializeField]
    private Vector3 m_subsequentCardOffset;

    private int cardCount = 0;

    public Vector3 GetLocationForNextCard()
    {
        return m_startingCardLocation.position + (m_subsequentCardOffset * cardCount);
    }

    public void OnDealCard()
    {
        ++cardCount;
    }
}
