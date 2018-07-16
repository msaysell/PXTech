using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public interface IGamblingMachine<T> where T : Wager
    {
        BettingResult Play(Wager wager);
        BettingResult Simulate(int iterations);
    }
}
