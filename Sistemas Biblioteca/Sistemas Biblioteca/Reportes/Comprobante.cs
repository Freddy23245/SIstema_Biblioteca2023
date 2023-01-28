using Sistemas_Biblioteca.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Biblioteca
{
    public partial class Comprobante : Form
    {
        private int _id_alumno;


        public int id_alumno
        {
            get { return _id_alumno;}
            set { _id_alumno = value; }

        }
        public Comprobante()

        {
            


            InitializeComponent();
        }

        private void Comprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.comprobante' Puede moverla o quitarla según sea necesario.
            //dsPrincipal.EnforceConstraints = false;
            //this.comprobanteTableAdapter.Fill(this.dsPrincipal.comprobante,id_alumno);
            Comprobante101 com = new Comprobante101();
            com.SetParameterValue("@id_alumno", id_alumno);
            crystalReportViewer1.ReportSource = com;
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comprobanteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
