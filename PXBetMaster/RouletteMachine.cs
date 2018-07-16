using System;
using System.Collections.Generic;

namespace PXBetMaster
{
   
//    Black Or Red Party
//This is a roulette-style machine, consisting of a disk with 62 evenly-spaced slots. 30 are red, 30 are black and 2 are white. A spinning ball stops randomly in one of these slots: each slot has an equal chance. The rules are these:
//•	The stake is £1
//•	The user selects red or black
//•	The user gets back double the stake (£2) if the ball stops in a slot of their selected colour
/// •	The user gets back 10% of their stake(£0.10 if the ball lands on a white.

    /// </summary>
    public enum RouletteOption {
        Red = 0,    
        Black = 1
    };
    public class RouletteMachine : BaseGamblingMachine, IGamblingMachine<RouletteWager>
    {
        private const ushort COLOUR_SLOTS_DEFAULT = 30;
        private const ushort WHITE_SLOTS_DEFAULT = 2;
        private const float WHITE_RETURNS = 0.1f;
        private const float COLOUR_RETURNS = 2.0f;

        public ushort RedSlots { get; set; }
        public ushort BlackSlots { get; set; }
        public ushort WhiteSlots { get; set; }


        public RouletteMachine(ushort redCount=RouletteMachine.COLOUR_SLOTS_DEFAULT,
            ushort blackCount = RouletteMachine.COLOUR_SLOTS_DEFAULT,
            ushort whiteCount = RouletteMachine.WHITE_SLOTS_DEFAULT)
        {
            RedSlots = redCount;
            BlackSlots = blackCount;
            WhiteSlots = whiteCount;
        }

        private int GetTotalSlots()
        {
            return RedSlots + BlackSlots + WhiteSlots;
        }

        public override BettingResult Play(Wager wager)
        {
            var rouletteWager = wager as RouletteWager;
            if (rouletteWager == null)
                throw new ArgumentException();

            var roll = this.rand.Next(GetTotalSlots());
            RouletteOption? result = null;
            var potentialReturns = rouletteWager.Stake * COLOUR_RETURNS;

            if (roll < this.RedSlots)
                result = RouletteOption.Red;
            else if (roll < this.RedSlots + this.BlackSlots)
                result = RouletteOption.Black;
            else
            {
                potentialReturns = rouletteWager.Stake * WHITE_RETURNS;
            }
            var wonBet = result == null || result == rouletteWager.Choice;

            return new BettingResult(rouletteWager.Stake, wonBet, wonBet ? potentialReturns : 0);
        }

        public override BettingResult Simulate(int iterations)
        {
            return this.RunSimulation(iterations, RouletteWager.TestFixture);
        }
    }
}
