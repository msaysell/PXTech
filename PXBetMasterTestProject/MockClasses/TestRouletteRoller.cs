using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PXBetMaster;

namespace PXBetMasterTestProject.MockClasses
{
    internal class TestRouletteRoller : IRouletteRoller
    {
        public ushort RedSlots { get; set; }
        public ushort BlackSlots { get; set; }
        public ushort WhiteSlots { get; set; }
        public int PreDeterminedSpin { private get; set; }
        public int SpinWheel()
        {
            return PreDeterminedSpin;
        }
    }
}
