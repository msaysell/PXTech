using System;
using System.Collections.Generic;
using System.Linq;

namespace PXBetMaster
{
    class DiceRollProvider : IDiceRollProvider
    {
        private Random rand = new Random();
        public ushort NumberOfDice { get; set; }
        public ushort DiceFaces { get; set; }

        public IEnumerable<int> RollDice()
        {
            return Enumerable.Range(1, NumberOfDice).Select(x => rand.Next(1, DiceFaces + 1));
        }
    }
}
