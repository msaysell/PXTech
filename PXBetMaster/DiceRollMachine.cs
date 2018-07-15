using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PXBetMaster
{
    public class DiceRollMachine : BaseGamblingMachine, IGamblingMachine<Wager>
    {
        private const ushort NumberOfDice = 2;
        private const ushort DiceFaces = 6;
        private const float returnRate = 1.5f;

        public override BettingResult Play<T>(T wager)
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
