using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_polynomial_solver {
    class GeneticAlgorithm {

        public readonly int PopulationSize = 1000;
        public readonly int Generations = 150;
        public static readonly double UpperBound = 1;
        public static readonly double LowerBound = -1;
        static readonly Random Random = new Random();

        public void Run(System.ComponentModel.BackgroundWorker worker, System.ComponentModel.DoWorkEventArgs e) {
            
            List<Chromosome> population = new List<Chromosome>(PopulationSize);

            for (int i = 0; i < PopulationSize; i++) {
                population.Add(new Chromosome(Polynomial.CoefficientCount));
            }

            for (int i = 0; i < Generations; i++) {
                population = RunGeneration(population);
                System.Diagnostics.Debug.WriteLine("Generation: " + i);
                if (i%5 == 0) {
                    worker.ReportProgress(0, population);
                }
                population = RunBreeding(population);
            }

           worker.ReportProgress(0, population);

        }

        private List<Chromosome> RunGeneration(List<Chromosome> population) {
            Polynomial polynomial = new Polynomial();
            for (int i = 0; i < PopulationSize; i++) {
                polynomial.Run(ChuPolynomialValues.XValues, population[i]);
                Fitness(population[i]);
            }
            return population;
        }

        private List<Chromosome> RunBreeding(List<Chromosome> population) {
            var sortedPopulation = population.OrderBy(chromosome => chromosome.Fitness).ToArray();

            int elitePopulationSize = (PopulationSize/100)*10; //%

            List<Chromosome> elitePopulation = new List<Chromosome>(elitePopulationSize);
            for (int i = 0; i < elitePopulationSize; i++) {
                elitePopulation.Add(sortedPopulation[i]);
            }

            int randomIntroducedPopulation = (PopulationSize/100)*10; //%
            List<Chromosome> randomIntorducedPopulation = new List<Chromosome>(elitePopulationSize);
            for (int i = 0; i < randomIntroducedPopulation; i++) {
                randomIntorducedPopulation.Add(new Chromosome(Polynomial.CoefficientCount));
            }

            int breedingPopulationSize = (PopulationSize - elitePopulationSize) - randomIntroducedPopulation;
            List<Chromosome> breedingPopulation = new List<Chromosome>(PopulationSize);
            //breed these

//            for (int i = 0; i < breedingPopulationSize; i+=2) {
//                Chromosome[] children = UniformCrossover(sortedPopulation[Random.Next(0, PopulationSize-elitePopulationSize)], sortedPopulation[Random.Next(0, PopulationSize-elitePopulationSize)]);
//                breedingPopulation.Add(children[0]);
//                breedingPopulation.Add(children[1]);
//            }

            for (int i = 0; i < breedingPopulationSize; i++) {
                Chromosome child = OneChildUniformCrossover(sortedPopulation[Random.Next(0, PopulationSize)], sortedPopulation[Random.Next(0, PopulationSize)]);
                breedingPopulation.Add(child);
            }

            foreach (Chromosome chromosome in breedingPopulation) {
                Mutation(chromosome, 0.9);
                HarshMutation(chromosome, 0.5);
            }

            return elitePopulation.Concat(breedingPopulation).Concat(randomIntorducedPopulation).ToList();
        }


        private double Fitness(Chromosome chromosome) {
            double differenceTotal = 0;
            for (int i = 0; i < chromosome.YValues.Length; i++) {
                double difference = Math.Abs(chromosome.YValues[i] - ChuPolynomialValues.YValues[i]);
                differenceTotal += difference*difference;
            }
            chromosome.Fitness = differenceTotal;
            return differenceTotal;
        }

        private Chromosome[] UniformCrossover(Chromosome parentOne, Chromosome parentTwo) {
            double[] childOneGene = new double[Polynomial.CoefficientCount];
            double[] childTwoGene = new double[Polynomial.CoefficientCount];
            for (int i = 0; i < Polynomial.CoefficientCount; i++) {
                if (Random.NextDouble() > 0.5d) {
                    childOneGene[i] = parentOne.Genome[i];
                    childTwoGene[i] = parentTwo.Genome[i];
                } else {
                    childOneGene[i] = parentTwo.Genome[i];
                    childTwoGene[i] = parentOne.Genome[i];
                }
            }
            return new[] { new Chromosome(childOneGene), new Chromosome(childTwoGene) };
        }

        private Chromosome OneChildUniformCrossover(Chromosome parentOne, Chromosome parentTwo) {
            double[] childOneGene = new double[Polynomial.CoefficientCount];
            for (int i = 0; i < Polynomial.CoefficientCount; i++) {
                if (Random.NextDouble() > 0.5d) {
                    childOneGene[i] = parentOne.Genome[i];
                } else {
                    childOneGene[i] = parentTwo.Genome[i];
                }
            }
            return new Chromosome(childOneGene);
        }

        private Chromosome[] OnePointCrossover(Chromosome parentOne, Chromosome parentTwo) {
            int crossoverPoint = Random.Next(1, Polynomial.CoefficientCount - 1);
            double[] childOneGene = new double[Polynomial.CoefficientCount];
            double[] childTwoGene = new double[Polynomial.CoefficientCount];
            for (int i = 0; i < Polynomial.CoefficientCount; i++) {
                if (i < crossoverPoint) {
                    childOneGene[i] = parentOne.Genome[i];
                    childTwoGene[i] = parentTwo.Genome[i];
                } else {
                    childOneGene[i] = parentTwo.Genome[i];
                    childTwoGene[i] = parentOne.Genome[i];
                }
            }
            return new []{ new Chromosome(childOneGene), new Chromosome(childTwoGene) };
        }

        private Chromosome Mutation(Chromosome chromosome, double probability) {
            if (Random.NextDouble() <= probability) {
                int gene = Random.Next(0, Polynomial.CoefficientCount);
                chromosome.Genome[gene] += ((Random.NextDouble() - 0.5d) * chromosome.Genome[gene]) / Random.Next(1,1000000);
            }
            return chromosome;
        }

        private Chromosome HarshMutation(Chromosome chromosome, double probability) {
            if (Random.NextDouble() <= probability) {
                int gene = Random.Next(0, Polynomial.CoefficientCount);
                chromosome.Genome[gene] = RandomValidGene();
            }
            return chromosome;
        }

        public static double RandomValidGene() {
            return Random.NextDouble() * (UpperBound - LowerBound) + LowerBound;
        }
    }
}
