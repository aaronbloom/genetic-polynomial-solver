# genetic-polynomial-solver

A simple genetic algorithm to find coefficients of a polynomial function.
Points of a target f(x) are taken as input. A random population of individuals are generated, each with their own Genome.
The fitness function finds the "distance" amoung each the individuals specified polynomial output and the target values.
Over each generation of the population the algorithm tries to find fittest individuals.

Uniform crossover breeding, harsh gene mutations and elitism are all applied.
