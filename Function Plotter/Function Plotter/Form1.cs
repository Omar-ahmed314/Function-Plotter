using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Plotter
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            initializeViews();
        }

        private void plot_Click(object sender, EventArgs e)
        {
            int mnValue = Convert.ToInt32(minValue.Value);
            int mxValue = Convert.ToInt32(maxValue.Value);
            if(mnValue > mxValue)
            {
                invalidRange.Visible = true;
                return;
            }
            invalidRange.Visible = false;

            string exp = equation.Text.Trim();
            if(exp.Length == 0)
            {
                invalidExpression.Visible = true;
                return;
            }
            invalidExpression.Visible = false;

            List<Point> points = controller.plot(mnValue, mxValue, exp);
            if(points == null)
            {
                invalidExpression.Visible = true;
                return;
            }
            invalidExpression.Visible = false;

            chart2.Series[0].Points.Clear();
            foreach(Point point in points)
            {
                chart2.Series[0].Points.AddXY(point.XCoordinate, point.YCoordinate);
            }
            chart2.Show();
        }

        private void initializeViews()
        {
            controller = Controller.instantiate();
            minValue.Minimum = Convert.ToDecimal(-1 * Math.Pow(2, 32) - 1);
            minValue.Maximum = Convert.ToDecimal(Math.Pow(2, 31) - 1);
            maxValue.Minimum = Convert.ToDecimal(-1 * Math.Pow(2, 32) - 1);
            maxValue.Maximum = Convert.ToDecimal(Math.Pow(2, 31) - 1);
            invalidExpression.Visible = false;
            invalidRange.Visible = false;
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
