using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
