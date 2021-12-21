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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.plot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invalidExpression = new System.Windows.Forms.Label();
            this.invalidRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea2.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.Interval = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 12);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(549, 224);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // equation
            // 
            this.equation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.equation.Location = new System.Drawing.Point(120, 260);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(274, 38);
            this.equation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equation";
            // 
            // minValue
            // 
            this.minValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minValue.Location = new System.Drawing.Point(120, 340);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(120, 20);
            this.minValue.TabIndex = 3;
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(120, 371);
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
            this.plot.Location = new System.Drawing.Point(416, 260);
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
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max value";
            // 
            // invalidExpression
            // 
            this.invalidExpression.AutoSize = true;
            this.invalidExpression.BackColor = System.Drawing.Color.Transparent;
            this.invalidExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidExpression.ForeColor = System.Drawing.Color.Red;
            this.invalidExpression.Location = new System.Drawing.Point(117, 301);
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
            this.invalidRange.Location = new System.Drawing.Point(117, 394);
            this.invalidRange.Name = "invalidRange";
            this.invalidRange.Size = new System.Drawing.Size(89, 17);
            this.invalidRange.TabIndex = 9;
            this.invalidRange.Text = "Invalid range";
            this.invalidRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 435);
            this.Controls.Add(this.invalidRange);
            this.Controls.Add(this.invalidExpression);
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
        private System.Windows.Forms.Label invalidExpression;
        private System.Windows.Forms.Label invalidRange;
    }
}

