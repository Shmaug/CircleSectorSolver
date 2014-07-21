using System;
using System.Windows.Forms;

namespace Circle_Sector_Solver
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void slvBtn_Click(object sender, EventArgs e)
        {
            double radius = (double) rad.Value;
            double angle = (double) ang.Value;
            double sector = (Math.PI * (radius*radius)) * (angle / 360.0);
            double sectorPi = (radius * radius) * (angle / 360);
            double aL = (2.0 * Math.PI * radius) * (angle / 360.0);
            double aLPi = (2.0 * radius) * (angle / 360.0);
            double h = radius * Math.Cos(angle / 2);
            double s = h * Math.Tan(angle / 2);
            double tri = h * s;
            double segment = sector - tri;
            secArea.Text = sector.ToString();
            arcLength.Text = aL.ToString();
            segArea.Text = segment.ToString();
            secPi.Text = sectorPi.ToString();
            arcPi.Text = aLPi.ToString();
        }
    }
}
