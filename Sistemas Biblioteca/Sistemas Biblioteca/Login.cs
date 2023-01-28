using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Logica;
using Soporte.Cache;
namespace Sistemas_Biblioteca
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text != "USUARIO")
            {
                if(txt_contraseña.Text != "CONTRASEÑA")
                {
                    Lusuarios usu = new Lusuarios();
                    var userLog = usu.LoginUser(txt_usuario.Text,  Seguridad.Encriptar(txt_contraseña.Text));
                 

                    if(userLog == true)
                    {
                        if(!Convert.ToBoolean(cache_usuario.habilitado))
                        {
                            msgError("El usuario esta bloqueado por que accedio " +Environment.NewLine + "    3 veces la Contraseña incorrecta");
                        }
                        else
                        {
                            usu.Hora_Ingreso1(cache_usuario.Id_usuario);
                            usu.IngresoUsuario(cache_usuario.Id_usuario);
                            Inicio ini = new Inicio();
                            ini.Show();
                            this.Hide();
                            
                        }
                        
                    }
                    else
                    {
                     
                        msgError("El usuario o la contraseña ingresada son incorrectas");
                        usu.IntentoPass(txt_usuario.Text, Seguridad.Encriptar(txt_contraseña.Text));
                        txt_contraseña.Clear();
                        txt_usuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor Ingrese la Contraseña");
                }
            }
            else
            {
                msgError("Por favor ingrese el usuario");
            }
                    

        }
        private void msgError(string str)
        {
            lblErrorMensaje.Text = "    " + str;
            lblErrorMensaje.Visible = true;
        }

        private void linkContraseñaOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rec = new RecuperarContraseña();
            rec.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = Color.DimGray;

            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "CONTRASEÑA")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.LightGray;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "CONTRASEÑA";
                txt_contraseña.ForeColor = Color.DimGray;

            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new Usuarios();
            reg.Show();
        }
    }
}
