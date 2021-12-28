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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equation = new System.Windows.Forms.TextBox();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.plot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invalidExpression = new System.Windows.Forms.Label();
            this.invalidRange = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Silver;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(12, 12);
            this.chart2.Name = "chart2";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(508, 224);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // equation
            // 
            this.equation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.Color.Silver;
            this.equation.Location = new System.Drawing.Point(6, 18);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(335, 38);
            this.equation.TabIndex = 1;
            this.equation.Text = "equation";
            this.equation.Enter += new System.EventHandler(this.equation_Enter);
            this.equation.Leave += new System.EventHandler(this.equation_Leave);
            // 
            // minValue
            // 
            this.minValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minValue.Location = new System.Drawing.Point(56, 102);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(120, 20);
            this.minValue.TabIndex = 3;
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(56, 128);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(120, 20);
            this.maxValue.TabIndex = 4;
            // 
            // plot
            // 
            this.plot.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.plot.FlatAppearance.BorderSize = 2;
            this.plot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plot.Location = new System.Drawing.Point(347, 19);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.plot.Size = new System.Drawing.Size(145, 140);
            this.plot.TabIndex = 5;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max";
            // 
            // invalidExpression
            // 
            this.invalidExpression.AutoSize = true;
            this.invalidExpression.BackColor = System.Drawing.Color.Transparent;
            this.invalidExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidExpression.ForeColor = System.Drawing.Color.Red;
            this.invalidExpression.Location = new System.Drawing.Point(29, 59);
            this.invalidExpression.Name = "invalidExpression";
            this.invalidExpression.Size = new System.Drawing.Size(120, 17);
            this.invalidExpression.TabIndex = 8;
            this.invalidExpression.Text = "Invalid expression";
            // 
            // invalidRange
            // 
            this.invalidRange.AutoSize = true;
            this.invalidRange.BackColor = System.Drawing.Color.Transparent;
            this.invalidRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidRange.ForeColor = System.Drawing.Color.Red;
            this.invalidRange.Location = new System.Drawing.Point(53, 152);
            this.invalidRange.Name = "invalidRange";
            this.invalidRange.Size = new System.Drawing.Size(89, 17);
            this.invalidRange.TabIndex = 9;
            this.invalidRange.Text = "Invalid range";
            this.invalidRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.plot);
            this.groupBox1.Controls.Add(this.invalidRange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.invalidExpression);
            this.groupBox1.Controls.Add(this.maxValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minValue);
            this.groupBox1.Controls.Add(this.equation);
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enteries";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 435);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox equation;
        private System.Windows.Forms.NumericUpDown minValue;
        private System.Windows.Forms.NumericUpDown maxValue;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label invalidExpression;
        private System.Windows.Forms.Label invalidRange;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

