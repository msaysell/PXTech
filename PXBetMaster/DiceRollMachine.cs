using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PXBetMaster
{
    public class DiceRollMachine : BaseGamblingMachine, IGamblingMachine<Wager>
    {
        public IDiceRollProvider DiceRoller { get; set; }
        private const float returnRate = 1.5f;

        public DiceRollMachine(ushort numberOfDice = 2, ushort diceFaceCount = 6)
        {
            this.DiceRoller = new DiceRollProvider() {
                NumberOfDice = numberOfDice,
                DiceFaces = diceFaceCount
            };
        }

        public override BettingResult Play(Wager wager)
        {
            var diceRolls = DiceRoller.RollDice();
            var allEqual = diceRolls.Distinct().Count() == 1;

            if(allEqual)
            {
                return new BettingResult(wager.Stake, true, (diceRolls.First()) * returnRate);
            }
            return new BettingResult(wager.Stake, false, 0.0f);
        }
    }
}
