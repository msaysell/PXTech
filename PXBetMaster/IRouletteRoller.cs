using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public interface IRouletteRoller
    {
        ushort RedSlots { get; set; }
        ushort BlackSlots { get; set; }
        ushort WhiteSlots { get; set; }
        int SpinWheel();
    }
}
