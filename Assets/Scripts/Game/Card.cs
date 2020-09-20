
public enum ECardSuit
{
    Clubs = 0,
    Diamonds = 1,
    Hearts = 2,
    Spades = 3,
    
    MaxValue = 4,
}

public enum ECardValue
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,

    MaxValue = 14
}

public class Card
{
    //did not have time to finish here, in real life, I would have given these more human readable names.
    private static string[] imageNames = { "cards_0", "cards_1", "cards_2", "cards_3", "cards_4", "cards_5", "cards_6", "cards_7", "cards_8", "cards_9", "cards_10", "cards_11", "cards_12", "cards_13", "cards_14", "cards_15", "cards_16", "cards_17", "cards_18", "cards_19", "cards_20", "cards_21", "cards_22", "cards_23", "cards_24", "cards_25", "cards_26", "cards_27", "cards_28", "cards_29", "cards_30", "cards_31", "cards_32", "cards_33", "cards_34", "cards_35", "cards_36", "cards_37", "cards_38", "cards_39", "cards_40", "cards_41", "cards_42", "cards_43", "cards_44", "cards_45", "cards_46", "cards_47", "cards_48", "cards_49", "cards_50", "cards_51"};

    public ECardSuit suit { get; }
    public ECardValue cardValue { get; }

    public Card(ECardSuit inSuit, ECardValue inCardValue)
    {
        suit = inSuit;
        cardValue = inCardValue;
    }

    // NOTE: untested, did not have time to test this
    public string GetImageName()
    {
        int suitIndex = (int)suit;
        int cardValueIndex = (int)cardValue - 1;
        int maxNumCards = (int)ECardValue.MaxValue - 1;

        int index = (suitIndex * maxNumCards) + cardValueIndex;

        return imageNames[index];
    }
}
