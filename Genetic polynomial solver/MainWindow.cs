using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Genetic_polynomial_solver {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        double graphNumberConstraint = 99999999999999;

        private Series candidateSeries;
        private Series bestCandidateFitness;
        private Series averageCandidateFitness;
        private Series worstCandidateFitness;

        private List<double> averageFitnessList = new List<double>();
        private List<double> worstFitnessList = new List<double>();
        private List<double> bestFitnessList = new List<double>();

        private void Form1_Load(object sender, EventArgs e) {
            candidateSeries = new Series();
            chartResult.Series.Add(candidateSeries);
            candidateSeries.ChartType = SeriesChartType.Point;
            chartResult.Series[0].ChartType = SeriesChartType.Point;
            for (int i = 0; i < ChuPolynomialValues.XValues.Length; i++) {
                chartResult.Series[0].Points.AddXY(ChuPolynomialValues.XValues[i], ChuPolynomialValues.YValues[i]);
            }

            bestCandidateFitness = new Series {
                ChartType = SeriesChartType.Line,
                BorderWidth = 5
            };
            worstCandidateFitness = new Series {
                ChartType = SeriesChartType.Line,
                BorderWidth = 5
            };
            averageCandidateFitness = new Series {
                ChartType = SeriesChartType.Line,
                BorderWidth = 5
            };
            chartProgress.Series.Add(bestCandidateFitness);
            chartProgress.Series.Add(worstCandidateFitness);
            chartProgress.Series.Add(averageCandidateFitness);

        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Start");
            GeneticAlgorithm ga = new GeneticAlgorithm();
            backgroundWorker1.RunWorkerAsync(ga);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            var worker = (System.ComponentModel.BackgroundWorker)sender;
            GeneticAlgorithm ga = (GeneticAlgorithm)e.Argument;
            ga.Run(worker, e);
        }

        private Chromosome fittestChromosome;
        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e) {
            List<Chromosome> chromosomes = (List<Chromosome>)e.UserState;
            fittestChromosome = chromosomes[0];
            System.Diagnostics.Debug.WriteLine("Fittest chromosome: " + fittestChromosome.Fitness);
            for (int i = 0; i < fittestChromosome.Genome.Length; i++) {
                System.Diagnostics.Debug.WriteLine(i + ": " + fittestChromosome.Genome[i]);
            }
            System.Diagnostics.Debug.WriteLine("Fittest chromosome¬");

            textBoxOutput.Text = "";
            /*foreach (double yValue in fittestChromosome.YValues) {
                textBoxOutput.AppendText(yValue + "\r\n");
            }*/
            candidateSeries.Points.Clear();
            for (int i = 0; i < ChuPolynomialValues.XValues.Length; i++) {
                for (int index = 0; index < chromosomes.Count && index < 10; index++) {
                    Chromosome chromosome = chromosomes[index];
                    candidateSeries.Points.AddXY(ChuPolynomialValues.XValues[i], chromosome.YValues[i]);
                }
            }
            textBoxFitnessValue.Text = fittestChromosome.Fitness.ToString();

            double worst = chromosomes.Max(chromosome => chromosome.Fitness);
            double best = chromosomes.Min(chromosome => chromosome.Fitness);
            double average = chromosomes.Average(chromosome => chromosome.Fitness);

            bestCandidateFitness.Points.AddY(best / graphNumberConstraint);
            //worstCandidateFitness.Points.AddY(worst / graphNumberConstraint);
            //averageCandidateFitness.Points.AddY(average / graphNumberConstraint);

            bestFitnessList.Add(best);
            worstFitnessList.Add(worst);
            averageFitnessList.Add(average);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            System.Diagnostics.Debug.WriteLine("Done");

            var csv = new StringBuilder();

            int x = 0;
            foreach (var d in averageFitnessList) {
                var newLine = string.Format("{0},{1}", x, d);
                csv.AppendLine(newLine);
                x++;
            }


            File.WriteAllText("average.csv", csv.ToString());


            csv = new StringBuilder();

            x = 0;
            foreach (var d in bestFitnessList) {
                var newLine = string.Format("{0},{1}", x, d);
                csv.AppendLine(newLine);
                x++;
            }


            File.WriteAllText("best.csv", csv.ToString());


            csv = new StringBuilder();

            x = 0;
            foreach (var d in worstFitnessList) {
                var newLine = string.Format("{0},{1}", x, d);
                csv.AppendLine(newLine);
                x++;
            }


            File.WriteAllText("worst.csv", csv.ToString());


            csv = new StringBuilder();

            for (int index = 0; index < fittestChromosome.YValues.Length; index++) {
                var d = fittestChromosome.YValues[index];
                var xv = ChuPolynomialValues.XValues[index];
                var newLine = string.Format("{0},{1}", xv, d);
                csv.AppendLine(newLine);
            }


            File.WriteAllText("yvalues.csv", csv.ToString());


            csv = new StringBuilder();

            for (int index = 0; index < fittestChromosome.Genome.Length; index++) {
                var d = fittestChromosome.Genome[index];
                var newLine = string.Format("{0}", d);
                csv.AppendLine(newLine);
            }


            File.WriteAllText("coeffs.csv", csv.ToString());
        }
    }
}
