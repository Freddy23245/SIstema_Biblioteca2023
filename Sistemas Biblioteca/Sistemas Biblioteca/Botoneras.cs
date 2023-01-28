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
    public partial class Botoneras : Form
    {

        public Botoneras()
        {
            InitializeComponent();
        }


        LReportes rep = new LReportes();
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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnCantAlulmnos_Click(object sender, EventArgs e)
        {
           
        }

        private void Botoneras_Load(object sender, EventArgs e)
        {
            IniciarControles();
        }
        private void IniciarControles()
        {
            lblCantidadAlumnos.Text = Convert.ToString(rep.CantidadAlumnos());
            lblCantidadLibros.Text = Convert.ToString(rep.CantidadLibros());
            lblCantidadLibrosDevueltos.Text = Convert.ToString(rep.CantidadDevueltos());
            lblCantidadLibrosNoDevueltos.Text = Convert.ToString(rep.CantidadNoDevueltos());
            lblPRestamos.Text = Convert.ToString(rep.CantidadPrestamos());
            lblCantidadRecaudada.Text = Convert.ToString(rep.Recaudacion().ToString("0.00"));
        }

        private void btnCantidadLibros_Click(object sender, EventArgs e)
        {
            Reportes.ReporteLibros rep = new Reportes.ReporteLibros();
            rep.ShowDialog();
        }

        private void btnCantAlulmnos_Click_1(object sender, EventArgs e)
        {
            Reportes.ReporteAlumnos rep = new Reportes.ReporteAlumnos();
            rep.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Reportes.Reporte_Libros_Devueltos rep = new Reportes.Reporte_Libros_Devueltos();
            rep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes.Reporte_Prestamos rep = new Reportes.Reporte_Prestamos();
            rep.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Reportes.Reporte_Libros_No_Devueltos rep = new Reportes.Reporte_Libros_No_Devueltos();
            rep.ShowDialog();
        }
       
       
    }
}
