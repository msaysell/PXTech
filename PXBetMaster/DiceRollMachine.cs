using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PXBetMaster
{
    public class DiceRollMachine : BaseGamblingMachine, IGamblingMachine<Wager>
    {
        public ushort NumberOfDice { get; set; }
        public ushort DiceFaces { get; set; }
        private const float returnRate = 1.5f;

        public DiceRollMachine(ushort numberOfDice = 2, ushort diceFaceCount = 6)
        {
            this.NumberOfDice = numberOfDice;
            this.DiceFaces = diceFaceCount;
        }

        public override BettingResult Play(Wager wager)
        {
            var diceRolls = Enumerable.Range(1, NumberOfDice).Select(x => rand.Next(DiceFaces));
            var allEqual = diceRolls.Distinct().Count() == 1;

            if(allEqual)
            {
                return new BettingResult(wager.Stake, true, (diceRolls.First() + 1) * returnRate);
            }
            return new BettingResult(wager.Stake, false, 0.0f);
        }
    }
}
