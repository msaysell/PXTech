using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public class Wager
    {
        public float Stake { get; set; }
        public static Wager TestFixture()
        {
            return new Wager() { Stake = 1.0f };
        }
    }
}
