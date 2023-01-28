using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Biblioteca.Reportes
{
    public partial class LibroMenos : Form
    {
        LibrosMenos rep = new LibrosMenos();
        public LibroMenos()
        {
            InitializeComponent();
          
        }

        private void dtp_año_ValueChanged(object sender, EventArgs e)
        {

            rep.SetParameterValue("@año", Convert.ToInt32(dtp_año.Text));
            crystalReportViewer1.ReportSource = rep;
        }

        private void LibroMenos_Load(object sender, EventArgs e)
        {
            dtp_año_ValueChanged(sender, e);
        }
    }
}
