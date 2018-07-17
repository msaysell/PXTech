using System;
using System.Collections.Generic;
using System.Linq;
using PXBetMaster;

namespace GamblingCLI
{
    class Program
    {
        static readonly int DEFAULT_SIMULATIONS = 100000;
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
            diceRoll.DiceRoller.DiceFaces = 4;
            var roulette = new RouletteMachine();
            var rouletteResults = roulette.Simulate(iterationCount);
            var diceRollResults = diceRoll.Simulate(iterationCount);

            var rouletteTitle = "Roulette";
            var diceRollTitle = "Dice Roll";
            var roulettePercentage = OutputSimResults(rouletteTitle, iterationCount, rouletteResults);
            var diceRollPercentage = OutputSimResults(diceRollTitle, iterationCount, diceRollResults);
            var bestMachine = "Neither";
            if (roulettePercentage > diceRollPercentage)
                if (IsWithinProfitLimit(rouletteTitle, roulettePercentage))
                    bestMachine = rouletteTitle;
                else
                    bestMachine = diceRollTitle;
            else if (diceRollPercentage > roulettePercentage)
                if (IsWithinProfitLimit(diceRollTitle, diceRollPercentage))
                    bestMachine = diceRollTitle;
                else
                    bestMachine = rouletteTitle;

            Console.WriteLine($"{bestMachine} would provide the best profit margin.\n");

            Console.WriteLine("Would you like to rerun the simulation? (y/n)");

            return Console.ReadLine().ToLower() == "y";

        }

        static bool IsWithinProfitLimit(string machineName, float percentage)
        {
            const float profitLimit = 0.1f;
            if (percentage > profitLimit)
            {
                Console.WriteLine($"ALERT: Profit Limit ({profitLimit:P2}) exceeded for {machineName}! Machine ineligible.");
                return false;
            }

            if (percentage < 0)
            {
                Console.WriteLine($"ALERT: {machineName} did not make any profit! Machine ineligible.");
                return false;
            }

            return true;

        }

        static float OutputSimResults(string machineName, int simulationCount, BettingResult resultsAvg)
        {
            var totalBet = resultsAvg.InitialStake;
            var totalWinnings = resultsAvg.Returns;
            var profitPercentage = 1.0f - (totalWinnings / totalBet);

            Console.WriteLine($"{machineName}: {simulationCount:n0} tests were run; Profit: £{totalBet - totalWinnings}; Profit Percentage: {profitPercentage:P2}");

            return profitPercentage;

        }
    }
}
