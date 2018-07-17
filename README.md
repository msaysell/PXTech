# PXTech

# Gambling CLI

A command line program that will run a simulation over the two different gambling machines, outputting an analysis of which machine is expected to provide the most profit.

Accepts a command line argument of a single integer to allow a larger number of iterations to run the simulation over, by default the simulation is done over 10,000 iterations.

# PXBetMaster

A class library providing different classes gambling machines, wagers, and a betting result.

# Profit Maximizer

A winforms form providing the simulation with options to change parameters of the gambling machines to determine the effects it would have on profit outcome.

---

# Questions and Answers

> Which of these two betting machines would be most appropriate to implement? 

The **Roulette** machine would be the most appropriate to implement. Whilst, the dice roll will provide larger profits, it cannot provide certainty that it will operate within limits.

An additional alternative to consider is to implement the dice roll machine using **4-sided dice** (Pyramid dice). This alternative would provide larger profits than the roulette machine and also fall within its given limits.

> How many tests do you recommend the users run to get sufficient confidence in the results? 

I'd recommend the users run in excess of **100,000 tests**. Running the simulation over the initial suggestion of 10,000 tests will occasionally emit a result showing that the dice roll machine provides larger profits and within limits. A simulation of 100,000 or more consistently provides results in a similar range which will alert its tester to the profit limits being exceeded.