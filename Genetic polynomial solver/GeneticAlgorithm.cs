using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace Genetic_polynomial_solver {
    class GeneticAlgorithm {

        public readonly int POPULATION_SIZE = 10000;
        public readonly int GENERATIONS = 100;
        public static readonly double HARSH_MUTATION_CHANCE = 0.9;
        public static readonly double REGULAR_MUTATION_CHANCE = 0.4;
        public static readonly int REGULAR_MUTATION_FACTOR = 10000;
        public static readonly int ELITE_POPULATION_PERCENTAGE = 20;
        public static readonly int RANDOM_POPULATION_PERCENTAGE = 30;
        static readonly Random random = new Random();

        public void Run(System.ComponentModel.BackgroundWorker worker, System.ComponentModel.DoWorkEventArgs e) {
            
            List<Chromosome> population = new List<Chromosome>(POPULATION_SIZE);

            //initial random chromosome generation
            for (int i = 0; i < POPULATION_SIZE; i++) {
                population.Add(new Chromosome(Polynomial.CoefficientCount, random));
            }

            //loop through generations of chromosomes
            for (int i = 0; i < GENERATIONS; i++) {
                population = RunGeneration(population);
                worker.ReportProgress(i / GENERATIONS * 100, population);
                System.Diagnostics.Debug.WriteLine("Generation: " + i);
                population = RunBreeding(population);
            }
        }

        //Loop through chromosomes and apply them to the polynomial and evaluate their fitness
        private List<Chromosome> RunGeneration(List<Chromosome> population) {
            Polynomial polynomial = new Polynomial();
            for (int i = 0; i < POPULATION_SIZE; i++) {
                polynomial.Run(ChuPolynomialValues.XValues, population[i]);
                Fitness(population[i]);
            }
            return population;
        }

        //Breed and mutate the chromosomes
        private List<Chromosome> RunBreeding(List<Chromosome> population) {
            var sortedPopulation = population.OrderBy(chromosome => chromosome.Fitness).ToList();

            //elite population creation
            int elitePopulationSize = (POPULATION_SIZE/100)*ELITE_POPULATION_PERCENTAGE; //%
            List<Chromosome> elitePopulation = new List<Chromosome>(elitePopulationSize);
            for (int i = 0; i < elitePopulationSize; i++) {
                elitePopulation.Add(sortedPopulation[i]);
            }

            //random introduced population creation
            int randomIntroducedPopulationSize = (POPULATION_SIZE/100)*RANDOM_POPULATION_PERCENTAGE; //%
            List<Chromosome> randomIntroducedPopulation = new List<Chromosome>(randomIntroducedPopulationSize);
            for (int i = 0; i < randomIntroducedPopulationSize; i++) {
                randomIntroducedPopulation.Add(new Chromosome(Polynomial.CoefficientCount, random));
            }

            int childPopulationSize = (POPULATION_SIZE - elitePopulationSize) - randomIntroducedPopulationSize;
            List<Chromosome> childPopulation = new List<Chromosome>(childPopulationSize);

            //elite breeding (half the child population)
            for (int i = 0; i < childPopulationSize/2; i++) {
                Chromosome child = OneChildUniformCrossover(sortedPopulation[random.Next(0, elitePopulationSize)], sortedPopulation[random.Next(0, elitePopulationSize)]);
                childPopulation.Add(child);
            }

            //entire population breeding  (half the child population)
            for (int i = 0; i < childPopulationSize/2; i++) {
                Chromosome child = OneChildUniformCrossover(sortedPopulation[random.Next(0, POPULATION_SIZE)], sortedPopulation[random.Next(0, POPULATION_SIZE)]);
                childPopulation.Add(child);
            }

            //mutation of child population
            foreach (Chromosome chromosome in childPopulation) {
                RegularMutation(chromosome, REGULAR_MUTATION_CHANCE);
                HarshMutation(chromosome, HARSH_MUTATION_CHANCE);
            }

            //creation of new generation
            return elitePopulation.Concat(childPopulation).Concat(randomIntroducedPopulation).ToList();
        }

        //Distance squared fitness function, with curve fitting tendency
        private static void Fitness(Chromosome chromosome) {
            double differenceTotal = 0;
            for (int i = 0; i < chromosome.YValues.Length; i++) {
                double difference = Math.Abs(chromosome.YValues[i] - ChuPolynomialValues.YValues[i]);
                if (i > 0) { //curve fitting
                    int prevDifferenceTarget = Math.Sign(ChuPolynomialValues.YValues[i] - ChuPolynomialValues.YValues[i - 1]);
                    int prevDifferenceCalculated = Math.Sign(chromosome.YValues[i] - chromosome.YValues[i - 1]);
                    if (prevDifferenceCalculated != prevDifferenceTarget) {
                        difference *= 2;  //double any difference if gradient direction does not match
                    }
                }
                differenceTotal += difference * difference; //point distance squared
            }
            chromosome.Fitness = differenceTotal;
        }

        //One child uniform crossover breeding with two parents
        private static Chromosome OneChildUniformCrossover(Chromosome parentOne, Chromosome parentTwo) {
            double[] childOneGene = new double[Polynomial.CoefficientCount];
            for (int i = 0; i < Polynomial.CoefficientCount; i++) {
                if (random.NextDouble() > 0.5d) {
                    childOneGene[i] = parentOne.Genome[i];
                } else {
                    childOneGene[i] = parentTwo.Genome[i];
                }
            }
            return new Chromosome(childOneGene);
        }

        //Deviates one gene of a chromosome by a percentage factor of the value
        private static void RegularMutation(Chromosome chromosome, double probability) {
            if (random.NextDouble() <= probability) {
                int gene = random.Next(0, Polynomial.CoefficientCount);
                chromosome.Genome[gene] += ((random.NextDouble() - 0.5d) * chromosome.Genome[gene]) / random.Next(1, REGULAR_MUTATION_FACTOR);
            }
        }

        //Randomly change one gene of a chromosome to a brand new random gene value
        private void HarshMutation(Chromosome chromosome, double probability) {
            if (random.NextDouble() <= probability) {
                int gene = random.Next(0, Polynomial.CoefficientCount);
                chromosome.Genome[gene] = Chromosome.RandomValidGene(random);
            }
        }
    }
}
