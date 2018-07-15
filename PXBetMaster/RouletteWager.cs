using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public class RouletteWager : Wager
    {
        public RouletteOption Choice { get; set; }
        public static new RouletteWager TestFixture()
        {
            var random = new Random();
            var options = Enum.GetValues(typeof(RouletteOption));
            var randomSelection = (RouletteOption)options.GetValue(random.Next(options.Length));
            return new RouletteWager()
            {
                Stake = 1.0f,
                Choice = randomSelection
            };
        }
    }
}
