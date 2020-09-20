using UnityEngine;

/// <summary>
/// Visual display for a single card
/// </summary>
public class CardView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer cardFrontRenderer;

    public Card card {get; set;}

    public void Initialize(Card inCard)
    {
        card = inCard;
        SelectSpriteFromCard();
    }

    private void SelectSpriteFromCard()
    {
        string imageName = card.GetImageName();
        Sprite sprite = Resources.Load<Sprite>(imageName);
        if (sprite != null)
        {
            cardFrontRenderer.sprite = sprite;
        }
    }
}
