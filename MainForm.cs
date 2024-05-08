using System.Windows.Forms.DataVisualization.Charting;

namespace IMLab11
{
    public partial class MainForm : Form
    {
        double[] _statistics;
        double[] _relativeStatistics;
        double[] _empyricalProbability;
        double[] _realProbability = new double[6];
        int N = 0;
        double _empyricalVariance = 0;
        double _empyricalMean = 0;
        double _realVariance = 0;
        double _realMean = 0;
        double _criteriaChi = 16.919; //m = 9, a = 0,05
        double _realChi = 0;
        double _meanError = 0;
        double _varianceError = 0;
        double[] _sample;
        double _sampleMax;
        double _sampleMin;
        double _step;
        int k = 10;
        Random _rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
            WriteTableHeadings();
        }
        double CalculateRV(double mean, double variance)
        {
            double z = Math.Cos(2*Math.PI*_rnd.NextDouble())*Math.Sqrt(-2*Math.Log(_rnd.NextDouble()));
            return mean + z * Math.Sqrt(variance);
        }
        void NullEverything()
        {
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            if (_statistics != null)
            {
                for (int i = 0; i < k; i++)
                {
                    _statistics[i] = 0;
                }
                for (int i = 0; i < N; i++)
                {
                    _sample[i] = 0;
                }
            }
            _empyricalMean = 0;
            _empyricalVariance = 0;
            _realMean = 0;
            _realVariance = 0;
            _realChi = 0;
            _meanError = 0;
            _varianceError = 0;
        }
        double P(double x)
        {
            return 1/Math.Sqrt(2*Math.PI*_empyricalVariance)*Math.Exp(-1*Math.Pow(x - _empyricalMean,2)/(2*_empyricalVariance));
        }
        void WriteParameters()
        {
            MeanLabel.Text = "Выборочное среднее: " + Math.Round(_realMean,2).ToString() + " Погрешность: " + (Math.Round(_meanError,2)*100).ToString() + "%";
            VarianceLabel.Text = "Дисперсия: " + Math.Round(_realVariance,2).ToString() + " Погрешность: " + Math.Round(_varianceError*100,2).ToString() + "%";
            if (_realChi>_criteriaChi)
            {
                ChiLabel.Text = "Критерий хи-квадрат: " + Math.Round(_realChi,2).ToString() + " > " + _criteriaChi.ToString() + " FALSE";
            }
            else
            {
                ChiLabel.Text = "Критерий хи-квадрат: " + Math.Round(_realChi, 2).ToString() + " < " + _criteriaChi.ToString() + " TRUE";
            }
        }
        void DrawChart()
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < k; i++)
            {
                chart1.Series[0].Points.AddXY(i, _relativeStatistics[i]);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 1, "(" + Math.Round((_sampleMin + _step * i), 2).ToString() + "; " + Math.Round((_sampleMin + _step * (i + 1)), 2).ToString() + "]", 0, LabelMarkStyle.None));
            }
        }
        Label CreateLabel()
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Width = 150;
            return label;
        }
        void WriteTableHeadings()
        {
            for (int i = 1; i <= 3; i++)
            {
                tableLayoutPanel1.Controls.Add(CreateLabel(), i, 0);
            }
            tableLayoutPanel1.GetControlFromPosition(1, 0).Text = "Среднее";
            tableLayoutPanel1.GetControlFromPosition(2, 0).Text = "Дисперсия";
            tableLayoutPanel1.GetControlFromPosition(3, 0).Text = "Хи-квадрат";
            for (int i = 1; i < 5; i++)
            {
                tableLayoutPanel1.Controls.Add(CreateLabel(), 0, i);
                tableLayoutPanel1.GetControlFromPosition(0, i).Text = Math.Pow(10,i).ToString();
            }
            for (int j = 1; j < 5; j++)
            {
                for (int i = 1; i <= 3; i++)
                {
                    tableLayoutPanel1.Controls.Add(CreateLabel(), i, j);
                }
            }
        }
        void GenerateSelection()
        {
            _empyricalMean = Double.Parse(MeanBox.Text);
            _empyricalVariance = Double.Parse(VarianceBox.Text);
            _sample = new double[N];
            for (int i = 0; i < N; i++)
            {
                _sample[i] = CalculateRV(_empyricalMean, _empyricalVariance);
            }
            _sampleMax = _sample.Max();
            _sampleMin = _sample.Min();
            _empyricalProbability = new double[k];
            _statistics = new double[k];
            _relativeStatistics = new double[k];
            for (int i = 0; i < k; i++)
            {
                _statistics[i] = 0;
                _relativeStatistics[i] = 0;
                _empyricalProbability[i] = 0;
            }
            _step = (_sampleMax - _sampleMin) / k;
            double stepLow = _sampleMin;
            double stepHigh = _sampleMin + _step;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((_sample[j] <= stepHigh) && (_sample[j] > stepLow))
                    {
                        _statistics[i]++;
                    }
                }
                _relativeStatistics[i] = _statistics[i] / N;
                stepLow += _step;
                stepHigh += _step;
            }
            _realMean = 0;
            _realVariance = 0;
            _realChi = 0;
            for (int i = 0; i < N; i++)
            {
                _realMean += _sample[i] / N;
            }
            for (int i = 0; i < N; i++)
            {
                _realVariance += Math.Pow(_sample[i] - _realMean, 2);
            }
            _realVariance = _realVariance / N;
            _meanError = Math.Abs(_realMean - _empyricalMean) / Math.Abs(_realMean);
            _varianceError = Math.Abs(_realVariance - _empyricalVariance) / Math.Abs(_realVariance);
            double a = 0;
            double b = 0;
            for (int i = 0; i < k; i++)
            {
                a = _sampleMin + _step * i;
                b = _sampleMin + _step * (i + 1);
                _empyricalProbability[i] = (b - a) * P((a + b) / 2);
            }
            for (int i = 0; i < k; i++)
            {
                _realChi += Math.Pow(_statistics[i], 2) / (_empyricalProbability[i] * N);
            }
            _realChi -= N;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            NullEverything();
            N = Int32.Parse(NumberOfTrialsBox.Text);
            GenerateSelection();
            DrawChart();
            WriteParameters();
        }
        void WriteStatistics(int row)
        {
            tableLayoutPanel1.GetControlFromPosition(1, row).Text = Math.Round(_realMean,2).ToString();
            tableLayoutPanel1.GetControlFromPosition(2, row).Text = Math.Round(_realVariance,2).ToString();
            tableLayoutPanel1.GetControlFromPosition(3, row).Text = Math.Round(_realChi,2).ToString();
        }
        private void FillTableButton_Click(object sender, EventArgs e)
        {
            NullEverything();
            for (int i = 1; i < 5; i++)
            {
                N = (int)Math.Pow(10, i);
                GenerateSelection();
                WriteStatistics(i);
                for (int j = 0; j < k; j++)
                {
                    _statistics[j] = 0;
                }
            }
        }
    }
}
