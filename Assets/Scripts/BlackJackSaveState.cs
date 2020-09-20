using System;

/// <summary>
/// Was meant for saving a Black Jack State, but never finished it. There was some consideration in changing to using BlackJackGameState to handle save/load instead.
/// </summary>
[Serializable]
public class BlackJackSaveState
{
    public int randomSeed;
    public int minBet;
    public int remainingDeckCount;
}
