using System;
using System.Collections.Generic;
using System.Text;

namespace PXBetMaster
{
    public class BaseGamblingMachine : IGamblingMachine<Wager>
    {
        protected Random rand { get; private set; }
        protected BaseGamblingMachine()
        {
            rand = new Random();
        }

        public BettingResult RunSimulation(int iterations, Func<Wager> testFixture)
        {
            var results = new List<BettingResult>();
            for (var i = 0; i < iterations; i++)
            {
                results.Add(this.Play(testFixture()));
            }
            return BettingResult.ResultsAverage(results);
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public virtual BettingResult Play<T>(T wager) where T : Wager
        {
            throw new NotImplementedException();
        }

        public virtual BettingResult Simulate(int iterations)
        {
            return RunSimulation(iterations, Wager.TestFixture);
        }
    }
}
