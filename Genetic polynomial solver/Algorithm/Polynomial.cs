using System;

namespace Genetic_polynomial_solver.Algorithm {
    internal class Polynomial {
        public static int CoefficientCount = 6;

        //Apply all the x values over the chromosome
        public void Run(double[] xValues, Chromosome chromosome) {
            double[] yValues = new double[xValues.Length];
            for (int i = 0; i < xValues.Length; i++) {
                yValues[i] = PolynomialFunction(xValues[i], chromosome);
            }
            chromosome.YValues = yValues;
        }

        //Apply the values in the chromosome onto the function, which gives back a y value
        private static double PolynomialFunction(double x, Chromosome chromosome) {
            return (chromosome.Genome[0]) +
                   (chromosome.Genome[1] * x) +
                   (chromosome.Genome[2] * Math.Pow(x, 2)) +
                   (chromosome.Genome[3] * Math.Pow(x, 3)) +
                   (chromosome.Genome[4] * Math.Pow(x, 4)) +
                   (chromosome.Genome[5] * Math.Pow(x, 5));
        }
    }
}
