using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_polynomial_solver {
    class Chromosome {
        public double[] Genome { get; }
        public double[] YValues { get; set; }
        public double Fitness { get; set; }

        public Chromosome(int geneCount) {
            Genome = new double[geneCount];

            for (int i = 0; i < geneCount; i++) {
                Genome[i] = GeneticAlgorithm.RandomValidGene();
            }
        }

        public Chromosome(double[] genome) {
            Genome = genome;
        }
    }
}
