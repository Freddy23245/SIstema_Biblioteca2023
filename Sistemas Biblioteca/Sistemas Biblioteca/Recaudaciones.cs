using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Logica;
using Soporte.Cache;
namespace Sistemas_Biblioteca
{
    public partial class Recaudaciones : Form
    {
       
        public Recaudaciones()
        {
            InitializeComponent();
        }

      
       
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Biblioteca",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCantAlulmnos_Click(object sender, EventArgs e)
        {
            Reportes.Reporte_de_Alumnos_Con_Mas_Concurrencia rep = new Reportes.Reporte_de_Alumnos_Con_Mas_Concurrencia();
            rep.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reportes.Recaudaciones_Mensuales rep = new Reportes.Recaudaciones_Mensuales();
            rep.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes.LibroMas rep = new Reportes.LibroMas();
            rep.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reportes.LibroMenos rep = new Reportes.LibroMenos();
            rep.ShowDialog();
        }
       
    }
}
