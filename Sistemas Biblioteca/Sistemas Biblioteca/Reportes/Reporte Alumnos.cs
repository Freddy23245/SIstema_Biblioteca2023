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
    public partial class Reporte_de_Alumnos_Con_Mas_Concurrencia : Form
    {
        public Reporte_de_Alumnos_Con_Mas_Concurrencia()
        {
            InitializeComponent();
        }

        private void dtpAño_ValueChanged(object sender, EventArgs e)
        {
            AlumnosMasPrestamos rep = new AlumnosMasPrestamos();
            rep.SetParameterValue("@año", Convert.ToInt32(dtpAño.Text));
            crystalReportViewer1.ReportSource = rep;
        }

        private void Reporte_de_Alumnos_Con_Mas_Concurrencia_Load(object sender, EventArgs e)
        {
            dtpAño_ValueChanged(sender, e);
        }
    }
}
