using System;
using System.Collections.Generic;
using System.Linq;
using PXBetMaster;

namespace GamblingCLI
{
    class Program
    {
        static readonly int DEFAULT_SIMULATIONS = 10000;
        static void Main(string[] args)
        {
            int simulationCount = DEFAULT_SIMULATIONS;
            if (args.Length > 0)
                if (!int.TryParse(args[0], out simulationCount))
                    simulationCount = DEFAULT_SIMULATIONS;

            do
            {
                Console.WriteLine("Running Simulation...");
            }
            while (SimulateOutcome(simulationCount));
        }

        static bool SimulateOutcome(int iterationCount)
        {
            var diceRoll = new DiceRollMachine();
            var roulette = new RouletteMachine();
            var rouletteResults = roulette.Simulate(iterationCount);
            var diceRollResults = diceRoll.Simulate(iterationCount);

            var rouletteTitle = "Roulette";
            var diceRollTitle = "Dice Roll";
            var roulettePercentage = OutputSimResults(rouletteTitle, iterationCount, rouletteResults);
            var diceRollPercentage = OutputSimResults(diceRollTitle, iterationCount, diceRollResults);
            var bestMachine = "Neither";
            if (roulettePercentage > diceRollPercentage)
                bestMachine = diceRollTitle;
            else if (roulettePercentage < diceRollPercentage)
                bestMachine = rouletteTitle;

            Console.WriteLine($"{bestMachine} would provide the best profit margin.\n");

            Console.WriteLine("Would you like to rerun the simulation? (y/n)");

            return Console.ReadLine().ToLower() == "y";

        }

        static float OutputSimResults(string machineName, int simulationCount, BettingResult resultsAvg)
        {
            var totalBet = resultsAvg.InitialStake;
            var totalWinnings = resultsAvg.Returns;
            var profitPercentage = totalWinnings / totalBet;

            Console.WriteLine($"{machineName}: {simulationCount:n0} tests were run; Profit: £{totalBet - totalWinnings}; Profit Percentage: {1.0 - profitPercentage:P2}");

            return profitPercentage;

        }
    }
}
