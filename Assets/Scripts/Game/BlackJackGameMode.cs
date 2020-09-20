
/// <summary>
/// Stores some constants about the game based on player inputs.
/// </summary>
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
