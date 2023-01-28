using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Capa_Logica;
namespace Sistemas_Biblioteca
{
    public partial class frmEditarPerfil : Form
    {
        Lusuarios usu = new Lusuarios();
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public frmEditarPerfil()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Salir de Editar Perfil?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void linkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panelCont.Visible == false)
            {
                panelCont.Visible = true;
                btnImagen.Visible = true;
            }
            else
            {
                panelCont.Visible = false;
                btnImagen.Visible = false;
            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {
                errorPerfil.SetError(txtNombre, "");
            }
            else
            {
                errorPerfil.SetError(txtUsuario, "El campo usuario Esta Vacio");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                errorPerfil.SetError(txtNombre, "");
            }
            else
            {
                errorPerfil.SetError(txtNombre, "El campo nombre Esta Vacio");
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text.Length > 0)
            {
                errorPerfil.SetError(txtApellido, "");
            }
            else
            {
                errorPerfil.SetError(txtApellido, "El campo apellido Esta Vacio");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                errorPerfil.SetError(txtEmail, "");
            }
            else
            {
                errorPerfil.SetError(txtEmail, "El campo email Esta Vacio");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Length > 0)
            {
                errorPerfil.SetError(txtContraseña, "");
            }
            else
            {
                errorPerfil.SetError(txtContraseña, "El campo contraseña Esta Vacio");
            }
        }

        private void txtConfirmarContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmarContraseña.Text.Length > 0)
            {
                errorPerfil.SetError(txtConfirmarContraseña, "");
            }
            else
            {
                errorPerfil.SetError(txtConfirmarContraseña, "El campo confirmar contraseña Esta Vacio");
            }
        }

        private void txtContraseñaActual_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseñaActual.Text.Length > 0)
            {
                errorPerfil.SetError(txtContraseñaActual, "");
            }
            else
            {
                errorPerfil.SetError(txtContraseñaActual, "El campo contraseña actual Esta Vacio");
            }
        }
        private byte[] ConvertirString()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureImagenPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            CargarPerfil();
            InizializePassEditControls();
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

        private void CargarPerfil()
        {
            lblUsuario.Text = cache_usuario.usuario;
            lblNombre.Text = cache_usuario.nombre;
            lblApellido.Text = cache_usuario.apellido;
            lblEmail.Text = cache_usuario.email;
            lblCargo.Text = usu.GrupoDeUsuario(cache_usuario.Id_usuario);

            if(pictureImagenPerfil.Image != null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(usu.Foto(cache_usuario.Id_usuario));
                pictureImagenPerfil.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    
                    
                }
            }else
            {
                pictureImagenPerfil.Image = Sistemas_Biblioteca.Properties.Resources.usuario;
            }
            

            txtUsuario.Text = cache_usuario.usuario;
            txtNombre.Text = cache_usuario.nombre;
            txtApellido.Text = cache_usuario.apellido;
            txtEmail.Text = cache_usuario.email;
            txtContraseña.Text = cache_usuario.contraseña;
            txtConfirmarContraseña.Text = cache_usuario.contraseña;
            txtContraseñaActual.Text = "";
                
        }

        private void InizializePassEditControls()
        {
            linkCambiarContraseña.Text = "Cambiar";
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Enabled = false;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.Enabled = false;
            txtContraseñaActual.UseSystemPasswordChar = true;
        }
        
        private void Reset()
        {
            CargarPerfil();
            InizializePassEditControls();
        }

        private void linkCambiarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkCambiarContraseña.Text == "Cambiar")
            {
                linkCambiarContraseña.Text = "Cancelar";
                txtContraseña.Enabled = true;
                txtContraseña.Text = string.Empty;
                txtConfirmarContraseña.Text = string.Empty;
                txtConfirmarContraseña.Enabled = true;
            }else if(linkCambiarContraseña.Text == "Cancelar")
            {
                Reset();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            string pass = Seguridad.Encriptar(txtContraseñaActual.Text);
            if(txtContraseña.Text == txtConfirmarContraseña.Text)//primero valida que la contraseñas coincidan
            {
                if(pass == cache_usuario.contraseña)//esto valida para terminar de hacer los cambios
                {
                        MemoryStream ms = new MemoryStream();
                        pictureImagenPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        var User = new Lusuarios(id_usuario: cache_usuario.Id_usuario, nombre: txtNombre.Text, apellido: txtApellido.Text, usuario: txtUsuario.Text, contraseña: Seguridad.Encriptar(txtContraseña.Text), email: txtEmail.Text, imagen: ms.GetBuffer());
                        var result = User.EditarPerfil();
                        usu.Foto(cache_usuario.Id_usuario);
                        MensajeOK(result);
                        txtContraseñaActual.Text = string.Empty;
                       
                }
                else
                {
                    MensajeError("Contraseña Actual Incorrecta");
                }
            }
            else
            {
                MensajeError("Las Contraseñas que ingreso no coinciden");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }
}
