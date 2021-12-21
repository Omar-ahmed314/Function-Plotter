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
            controller = Controller.instantiate();
        }

        private void plot_Click(object sender, EventArgs e)
        {
            int mnValue = Convert.ToInt32(minValue.Value);
            int mxValue = Convert.ToInt32(maxValue.Value);
            string exp = equation.Text;
            List<Point> points = controller.plot(mnValue, mxValue, exp);
            chart2.Series.Clear();
            foreach(Point point in points)
            {
                chart2.Series["Series1"].Points.AddXY(point.XCoordinate, point.YCoordinate);
            }
            chart2.Show();
        }
    }
}
