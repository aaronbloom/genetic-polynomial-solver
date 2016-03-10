using System;

namespace Genetic_polynomial_solver.Algorithm {
    class Chromosome {
        public double[] Genome { get; }
        public double[] YValues { get; set; }
        public double Fitness { get; set; }

        private static readonly double RANDOM_GENE_UPPER_BOUND = 1;
        private static readonly double RANDOM_GENE_LOWER_BOUND = -1;

        public Chromosome(int geneCount, Random random) {
            Genome = new double[geneCount];

            for (int i = 0; i < geneCount; i++) {
                Genome[i] = Chromosome.RandomValidGene(random);
            }
        }

        public Chromosome(double[] genome) {
            Genome = genome;
        }

        public static double RandomValidGene(Random random) {
            return random.NextDouble() * (RANDOM_GENE_UPPER_BOUND - RANDOM_GENE_LOWER_BOUND) + RANDOM_GENE_LOWER_BOUND;
        }
    }
}
