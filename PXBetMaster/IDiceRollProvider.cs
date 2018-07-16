using System.Collections.Generic;
namespace PXBetMaster
{
    public interface IDiceRollProvider
    {
        ushort NumberOfDice { get; set; }
        ushort DiceFaces { get; set; }
        IEnumerable<int> RollDice();
    }
}