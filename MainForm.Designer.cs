﻿namespace IMLab11
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            MeanBox = new TextBox();
            VarianceBoxLabel = new Label();
            VarianceBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            NumberOfTrialsLabel = new Label();
            NumberOfTrialsBox = new TextBox();
            StartButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            FillTableButton = new Button();
            MeanLabel = new Label();
            VarianceLabel = new Label();
            ChiLabel = new Label();
            MeanBoxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // MeanBox
            // 
            MeanBox.Location = new Point(218, 107);
            MeanBox.Name = "MeanBox";
            MeanBox.Size = new Size(100, 23);
            MeanBox.TabIndex = 6;
            // 
            // VarianceBoxLabel
            // 
            VarianceBoxLabel.AutoSize = true;
            VarianceBoxLabel.Location = new Point(89, 136);
            VarianceBoxLabel.Name = "VarianceBoxLabel";
            VarianceBoxLabel.Size = new Size(70, 15);
            VarianceBoxLabel.TabIndex = 9;
            VarianceBoxLabel.Text = "Дисперсия:";
            // 
            // VarianceBox
            // 
            VarianceBox.Location = new Point(218, 133);
            VarianceBox.Name = "VarianceBox";
            VarianceBox.Size = new Size(100, 23);
            VarianceBox.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(479, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Частоты";
            chart1.Series.Add(series1);
            chart1.Size = new Size(650, 464);
            chart1.TabIndex = 13;
            chart1.Text = "chart1";
            // 
            // NumberOfTrialsLabel
            // 
            NumberOfTrialsLabel.AutoSize = true;
            NumberOfTrialsLabel.Location = new Point(89, 165);
            NumberOfTrialsLabel.Name = "NumberOfTrialsLabel";
            NumberOfTrialsLabel.Size = new Size(126, 15);
            NumberOfTrialsLabel.TabIndex = 15;
            NumberOfTrialsLabel.Text = "Количество попыток:";
            // 
            // NumberOfTrialsBox
            // 
            NumberOfTrialsBox.Location = new Point(218, 162);
            NumberOfTrialsBox.Name = "NumberOfTrialsBox";
            NumberOfTrialsBox.Size = new Size(100, 23);
            NumberOfTrialsBox.TabIndex = 14;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(177, 228);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 16;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5313272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.531332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.2807F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(12, 333);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(461, 143);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // FillTableButton
            // 
            FillTableButton.Location = new Point(151, 482);
            FillTableButton.Name = "FillTableButton";
            FillTableButton.Size = new Size(150, 23);
            FillTableButton.TabIndex = 18;
            FillTableButton.Text = "Заполнить таблицу";
            FillTableButton.UseVisualStyleBackColor = true;
            FillTableButton.Click += FillTableButton_Click;
            // 
            // MeanLabel
            // 
            MeanLabel.AutoSize = true;
            MeanLabel.Location = new Point(561, 486);
            MeanLabel.Name = "MeanLabel";
            MeanLabel.Size = new Size(128, 15);
            MeanLabel.TabIndex = 19;
            MeanLabel.Text = "Выборочное среднее:";
            // 
            // VarianceLabel
            // 
            VarianceLabel.AutoSize = true;
            VarianceLabel.Location = new Point(561, 501);
            VarianceLabel.Name = "VarianceLabel";
            VarianceLabel.Size = new Size(70, 15);
            VarianceLabel.TabIndex = 20;
            VarianceLabel.Text = "Дисперсия:";
            // 
            // ChiLabel
            // 
            ChiLabel.AutoSize = true;
            ChiLabel.Location = new Point(561, 516);
            ChiLabel.Name = "ChiLabel";
            ChiLabel.Size = new Size(126, 15);
            ChiLabel.TabIndex = 21;
            ChiLabel.Text = "Критерий хи-квадрат:";
            // 
            // MeanBoxLabel
            // 
            MeanBoxLabel.AutoSize = true;
            MeanBoxLabel.Location = new Point(89, 110);
            MeanBoxLabel.Name = "MeanBoxLabel";
            MeanBoxLabel.Size = new Size(84, 15);
            MeanBoxLabel.TabIndex = 22;
            MeanBoxLabel.Text = "Матожидание";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 561);
            Controls.Add(MeanBoxLabel);
            Controls.Add(ChiLabel);
            Controls.Add(VarianceLabel);
            Controls.Add(MeanLabel);
            Controls.Add(FillTableButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(StartButton);
            Controls.Add(NumberOfTrialsLabel);
            Controls.Add(NumberOfTrialsBox);
            Controls.Add(chart1);
            Controls.Add(VarianceBoxLabel);
            Controls.Add(VarianceBox);
            Controls.Add(MeanBox);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProbBox1;
        private Label ProbLabel1;
        private Label ProbLabel2;
        private TextBox ProbBox2;
        private Label ProbLabel3;
        private TextBox ProbBox3;
        private Label ProbLabel4;
        private TextBox MeanBox;
        private Label VarianceBoxLabel;
        private TextBox VarianceBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label NumberOfTrialsLabel;
        private TextBox NumberOfTrialsBox;
        private Button StartButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button FillTableButton;
        private Label MeanLabel;
        private Label VarianceLabel;
        private Label ChiLabel;
        private Label MeanBoxLabel;
    }
}
