using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PXBetMaster;

namespace PXBetMasterTestProject
{
    class TestDiceRollProvider : IDiceRollProvider
    {
        public ushort NumberOfDice { get; set; }
        public ushort DiceFaces { get; set; }

        public IEnumerable<int> PreDeterminedRolls { private get; set; }
        public IEnumerable<int> RollDice()
        {
            return this.PreDeterminedRolls;
        }
    }
}
