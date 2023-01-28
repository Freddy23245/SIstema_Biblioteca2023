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
    public partial class LibroMas : Form
    {
        LibrosMas103 rep = new LibrosMas103();
        public LibroMas()
        {
            InitializeComponent();
            
        }

        private void dtpAño_ValueChanged(object sender, EventArgs e)
        {
            
            rep.SetParameterValue("@año", Convert.ToInt32(dtpAño.Text));
            crystalReportViewer1.ReportSource = rep;
        }

        private void LibroMas_Load(object sender, EventArgs e)
        {
            
            dtpAño_ValueChanged(sender, e);
            
        }
    }
}
