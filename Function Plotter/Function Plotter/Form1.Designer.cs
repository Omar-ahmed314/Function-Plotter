namespace Function_Plotter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.plot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(12, 12);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(549, 224);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // equation
            // 
            this.equation.Location = new System.Drawing.Point(87, 260);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(474, 20);
            this.equation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equation";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(87, 318);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(120, 20);
            this.minValue.TabIndex = 3;
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(441, 318);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(120, 20);
            this.maxValue.TabIndex = 4;
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(441, 387);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(120, 23);
            this.plot.TabIndex = 5;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max value";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(577, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.chart2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox equation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minValue;
        private System.Windows.Forms.NumericUpDown maxValue;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

