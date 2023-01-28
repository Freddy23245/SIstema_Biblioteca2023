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
using System.IO;
using Soporte.Cache;

namespace Sistemas_Biblioteca
{
    public partial class Usuarios : Form
    {
        Lusuarios usuarios = new Lusuarios();
        public Usuarios()
        {
            InitializeComponent();
        }

     

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {

            InizializePassEditControls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
            string pass = Seguridad.Encriptar(txtContraseña.Text);
            string confpass = Seguridad.Encriptar(txtConfirmarContraseña.Text);
            if (txtContraseña.Text == txtConfirmarContraseña.Text)//primero valida que la contraseñas coincidan
            {
                
                    MemoryStream ms = new MemoryStream();
                    pictureImagenPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var User = new Lusuarios(id_usuario:0,nombre: txtNombre.Text, apellido: txtApellido.Text, usuario: txtUsuario.Text, contraseña: Seguridad.Encriptar(txtContraseña.Text), email: txtEmail.Text, imagen: ms.GetBuffer());
                    var result = User.RegistrarUsuario();
              
                    MensajeOK(result);
                    this.Close();

            }
            else
            {
                MensajeError("Las Contraseñas que ingreso no coinciden");
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult dr = fo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pictureImagenPerfil.Image = Image.FromFile(fo.FileName);
            }
        }
        private void InizializePassEditControls()
        {
           
            txtContraseña.UseSystemPasswordChar = true;
      
            txtConfirmarContraseña.UseSystemPasswordChar = true;
           
          
        }


        
    }
}
