using System;
using System.Collections.Generic;

public enum EGamePhase
{
    PlacingBets = 0,
    ReceivingCards = 1,
    Action = 2,
    BetsResolving = 3,
}

public class BlackJackGameState
{
    public EGamePhase currentPhase { get; set; } = EGamePhase.PlacingBets;

    public int randomSeed { get; }

    public List<Card> deck;

    public BlackJackGameState(int numDecks)
    {
        randomSeed = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
        UnityEngine.Random.InitState(randomSeed);
        InitializeDeck(numDecks);
        ShuffleDeck();
    }

    /// <summary>
    /// populate deck with cards
    /// </summary>
    /// <param name="numDecks"></param>
    private void InitializeDeck(int numDecks)
    {
        int maxNumCardFaces = (int)ECardValue.MaxValue;
        int maxNumSuits = (int)ECardSuit.MaxValue;
        deck = new List<Card>(numDecks * (maxNumCardFaces - 1) * maxNumSuits);

        for (int i = 0; i < numDecks; i++)
        {
            for (int j = 0; j < maxNumSuits; j++)
            {
                for (int k = 1; k < maxNumCardFaces; k++)
                {
                    deck.Add(new Card((ECardSuit)j, (ECardValue)k));
                }
            }
        }
    }

    /// <summary>
    /// shuffle all the cards
    /// </summary>
    private void ShuffleDeck()
    {
        //randomly swap places of cards, O(n) operation
        for (int i = 0; i < deck.Count; i++)
        {   
            int randIndex = UnityEngine.Random.Range(0, deck.Count);
            Card tempCard = deck[i];
            deck[i] = deck[randIndex];
            deck[randIndex] = tempCard;
        }
    }
}
