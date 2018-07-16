using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    class RouletteRoller : IRouletteRoller
    {
        private Random rand = new Random();
        public ushort RedSlots { get; set; }
        public ushort BlackSlots { get; set; }
        public ushort WhiteSlots { get; set; }

        private int GetTotalSlots()
        {
            return RedSlots + BlackSlots + WhiteSlots;
        }

        public int SpinWheel()
        {
            return this.rand.Next(GetTotalSlots());
        }
    }
}
