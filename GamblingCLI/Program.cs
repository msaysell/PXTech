using System;
using System.Collections.Generic;
using System.Linq;
using PXBetMaster;

namespace GamblingCLI
{
    class Program
    {
        static readonly int SIMULATIONS = 10000;
        static void Main(string[] args)
        {
            var diceRoll = new DiceRollMachine();
            var roulette = new RouletteMachine();
            var rouletteResults = roulette.Simulate(SIMULATIONS);
            var diceRollResults = diceRoll.Simulate(SIMULATIONS);

            var rouletteTitle = "Roulette";
            var diceRollTitle = rouletteTitle;
            var roulettePercentage = OutputSimResults(rouletteTitle, rouletteResults);
            var diceRollPercentage = OutputSimResults(rouletteTitle, diceRollResults);
            var bestMachine = "Neither";
            if (roulettePercentage > diceRollPercentage)
                bestMachine = diceRollTitle;
            else if (roulettePercentage < diceRollPercentage)
                bestMachine = rouletteTitle;

            Console.WriteLine($"{bestMachine} would provide the best profit margin.");  
            Console.ReadKey();
        }

        static float OutputSimResults(string machineName, BettingResult resultsAvg)
        {
            var totalBet = resultsAvg.InitialStake;
            var totalWinnings = resultsAvg.Returns;
            var profitPercentage = totalWinnings / totalBet;

            Console.WriteLine($"{machineName}: {SIMULATIONS:n0} tests were run; Profit: £{totalBet - totalWinnings}; Profit Percentage: {1.0 - profitPercentage:P2}");

            return profitPercentage;

        }
    }
}
