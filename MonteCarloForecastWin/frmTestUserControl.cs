using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloForecastWin
{
    public partial class frmTestUserControl : Form
    {
        public frmTestUserControl()
        {
            InitializeComponent();
        }

        private void forecastCtl1_OnGetHistoricSamples(object sender, HistoricSamplesEventArgs args)
        {
            args.Samples = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
