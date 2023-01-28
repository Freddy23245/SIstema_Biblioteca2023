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
using System.IO;
namespace Sistemas_Biblioteca
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
         
        }
  
        /// <summary>
        /// ////////////////////////////////////////
        /// </summary>
       
        Lusuarios usu = new Lusuarios();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void CargarPerfil()
        {
            if(picInicio.Image == null)
            {
                picInicio.Image = Sistemas_Biblioteca.Properties.Resources.usuario;
            }
            else
            {

                try
                {
                    MemoryStream ms = new MemoryStream(usu.Foto(cache_usuario.Id_usuario));
                    picInicio.Image = Image.FromStream(ms);
                }
                catch (Exception )
                {

               
                }
            }
            
            lblNombreUsuario.Text = cache_usuario.nombre + "  " + cache_usuario.apellido;
            lblUsuario.Text = cache_usuario.usuario;
            lblEmail.Text = cache_usuario.email;
            lblCargo.Text = usu.GrupoDeUsuario(cache_usuario.Id_usuario);
            
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            CargarPerfil();
            Permisos();
            tHora.Enabled = true;
            MostrarBotonera();
        }
      
        public void MostrarDatos()
        {
            lblUsuario.Text = cache_usuario.usuario;
            lblNombreUsuario.Text = cache_usuario.nombre + " " + cache_usuario.apellido;
        }

        //public void AbrirFormEnPanel(object Formhijo)
        //{
        //    if (this.PanelContenedor.Controls.Count > 0)
        //        this.PanelContenedor.Controls.RemoveAt(0);
        //    Form fh = Formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.PanelContenedor.Controls.Add(fh);
        //    this.PanelContenedor.Tag = fh;
        //    fh.Show();
        //}
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Alumnos"] == null)
                btnAlumnos.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Autores"] == null)
                btnAutores.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Editoriales"] == null)
                btnEditoriales.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Genero"] == null)
                btnGeneros.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Gestiones"] == null)
                btnGestiones.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Libros"] == null)
                btnRegistroLibro.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Prestamos"] == null)
                btnPrestamos.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["Recaudaciones"] == null)
                btnReportes.BackColor = Color.FromArgb(0, 122, 204);
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 270)
            {
                MenuVertical.Width = 70;
                gbCont.Visible = false;
            }
            else
            {
                MenuVertical.Width = 270;
                gbCont.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;
            cons = MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                Application.Exit();
        }
        int LY, LX,SW,SH;
        
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LY = this.Location.Y;
            LX = this.Location.X;
            SW = this.Width;
            SH = this.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW,SH);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Alumnos>();
            btnAlumnos.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void btnRegistroLibro_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Libros>();
            btnRegistroLibro.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Autores>();
            btnAutores.BackColor = Color.FromArgb(40, 45, 48);

        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<Editoriales>();
            btnEditoriales.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Genero>();
            btnGeneros.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<Prestamos>();
            btnPrestamos.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Recaudaciones>();
            btnReportes.BackColor = Color.FromArgb(40, 45, 48);
        }

        private void linkeditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            AbrirFormulario<frmEditarPerfil>();
        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<Gestiones>();
            btnGestiones.BackColor = Color.FromArgb(40, 45, 48);
        }
        private void MostrarBotonera()
        {
        
            AbrirFormulario<Botoneras>();
        }

        private void Permisos()
        {
            DataTable dt;
            dt = usu.ValidarPermisos(cache_usuario.Id_usuario);

            btnAlumnos.Visible = false;
            btnRegistroLibro.Visible = false;
            btnAutores.Visible = false;
            btnEditoriales.Visible = false;
            btnGeneros.Visible = false;
            btnGestiones.Visible = false;
            btnPrestamos.Visible = false;
            btnReportes.Visible = false;


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (dt.Rows[i]["Permisos"].ToString().Equals("Alumnos"))
                    btnAlumnos.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Editoriales"))
                    btnEditoriales.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Libros"))
                    btnRegistroLibro.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Autores"))
                    btnAutores.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Generos"))
                    btnGeneros.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Gestiones"))
                    btnGestiones.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Prestamos"))
                    btnPrestamos.Visible = true;
                if (dt.Rows[i]["Permisos"].ToString().Equals("Reportes"))
                    btnReportes.Visible = true;
           



            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Cerrar Sesion?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
            {
                usu.Hora_Salida1(cache_usuario.Id_usuario);
                this.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

       

    


    }
}
