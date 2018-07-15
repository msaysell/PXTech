using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public interface IGamblingMachine<T> where T : Wager
    {
        BettingResult Play<WagerT>(WagerT wager) where WagerT : Wager;
        BettingResult Simulate(int iterations);
    }
}
