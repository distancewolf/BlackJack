using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ECardSuit
{
    Clubs = 0,
    Spades = 1,
    Hearts = 2,
    Diamonds = 3,

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
    public ECardSuit suit;
    public ECardValue cardValue;

    public Card(ECardSuit inSuit, ECardValue inCardValue)
    {
        suit = inSuit;
        cardValue = inCardValue;
    }
}
