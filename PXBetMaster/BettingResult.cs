using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PXBetMaster
{
    public class BettingResult
    {
        public float InitialStake { get; private set; }
        public bool IsSuccess { get; private set; }
        public float Returns { get; private set; }

        public BettingResult(float stake, bool success, float returns)
        {
            this.InitialStake = stake;
            this.IsSuccess = success;
            this.Returns = returns;
        }
        
        public static BettingResult ResultsAverage(IEnumerable<BettingResult> results)
        {
            float totalStake = 0, totalReturns = 0;
            foreach(var result in results)
            {
                totalStake += result.InitialStake;
                totalReturns += result.Returns;
            }
            bool moreOrEqualWinsOverall = results.Count(res => res.IsSuccess) >= (results.Count() >> 1);
            return new BettingResult(totalStake, moreOrEqualWinsOverall, totalReturns);
        }
    }
}
