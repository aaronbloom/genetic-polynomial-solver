using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Genetic_polynomial_solver {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private int xValue = 0;
        private Series candidateSeries;
        private Series bestCandidateFitness;
        private Series worstCandidateFitness;
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
            chartProgress.Series.Add(bestCandidateFitness);
            chartProgress.Series.Add(worstCandidateFitness);

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

        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e) {
            List<Chromosome> chromosomes = (List<Chromosome>)e.UserState;
            Chromosome fittestChromosome = chromosomes[0];
            System.Diagnostics.Debug.WriteLine("Fittest chromosome: " + fittestChromosome.Fitness);
            for (int i = 0; i < fittestChromosome.Genome.Length; i++) {
                System.Diagnostics.Debug.WriteLine(i + ": " + fittestChromosome.Genome[i]);
            }
            System.Diagnostics.Debug.WriteLine("Fittest chromosome¬");

            textBoxOutput.Text = "";
            foreach (double yValue in fittestChromosome.YValues) {
                textBoxOutput.AppendText(yValue + "\r\n");
            }
            candidateSeries.Points.Clear();
            for (int i = 0; i < ChuPolynomialValues.XValues.Length; i++) {
                for (int index = 0; index < chromosomes.Count && index < 10; index++) {
                    Chromosome chromosome = chromosomes[index];
                    candidateSeries.Points.AddXY(ChuPolynomialValues.XValues[i], chromosome.YValues[i]);
                }
            }
            textBoxFitnessValue.Text = fittestChromosome.Fitness.ToString();
            bestCandidateFitness.Points.AddY(chromosomes.Min(chromosome => chromosome.Fitness) / 99999999999999);
            //worstCandidateFitness.Points.AddY(chromosomes.Max(chromosome=>chromosome.Fitness)/ 99999999999999);
            if (xValue % 5 == 0) {
                bestCandidateFitness.Points.RemoveAt(0);
                //worstCandidateFitness.Points.RemoveAt(0);
            }
            xValue++;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

        }
    }
}
