using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJackGameMode
{
    public int minBet { get; }
    public int startingCash { get; }

    public int numDecks { get; }

    public BlackJackGameMode(int inMinBet, int inStartingCash)
    {
        minBet = inMinBet;
        startingCash = inStartingCash;
        numDecks = 8;
    }

}
