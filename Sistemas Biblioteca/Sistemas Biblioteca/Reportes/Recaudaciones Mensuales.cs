
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
    public partial class Recaudaciones_Mensuales : Form
    {
        public Recaudaciones_Mensuales()
        {
            InitializeComponent();
        }

        private void Recaudaciones_Mensuales_Load(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dtp_año_ValueChanged(object sender, EventArgs e)
        {
            Recaudaciones101 rep = new Recaudaciones101();
            rep.SetParameterValue("@año", Convert.ToInt32(dtp_año.Text));
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
