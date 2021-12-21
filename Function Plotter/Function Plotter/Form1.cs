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
            List<Point> points = controller.plot(int.Parse(minValue.Value.ToString()), int.Parse(maxValue.Value.ToString()), equation.Text);
        }
    }
}
