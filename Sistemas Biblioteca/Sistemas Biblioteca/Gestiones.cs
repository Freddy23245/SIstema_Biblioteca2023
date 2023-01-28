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
namespace Sistemas_Biblioteca
{
    public partial class Gestiones : Form
    {
        public Gestiones()
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
        Lusuarios usu = new Lusuarios();
        private void Gestiones_Load(object sender, EventArgs e)
        {
            mostrarUSuarios();
            MostrarGrupos();
            MostrarPermisos();
            MostrarGruposPermisos();
        }
        private void mostrarUSuarios()
        {
            DataTable dt;
            dt = usu.mostrar();
            cboUsuarios.DataSource = dt;
            cboUsuarios.ValueMember = "id_usuario";
            cboUsuarios.DisplayMember = "usuario";
        }
        private void MostrarPermisos()
        {
            DataTable dt;
            dt = usu.mostrarPermisos();
            cboPermisos.DataSource = dt;
            cboPermisos.DisplayMember = "nombre";
            cboPermisos.ValueMember = "id_permiso";
        }
        private void MostrarGrupos()
        {
            DataTable dt;
            dt = usu.mostrarGrupos();
            cboGrupos.DataSource = dt;
            cboGrupos.DisplayMember = "nombre";
            cboGrupos.ValueMember = "id_grupo";

            cboGruposPer.DataSource = dt;
            cboGruposPer.DisplayMember = "nombre";
            cboGruposPer.ValueMember = "id_grupo";

        }

        private void MostrarGruposPermisos()
        {
            DataTable dt = new DataTable();
            dt = usu.MostrarGruposPermisos();
            dt_gruposPermisos.DataSource = dt;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarUsuGrupo()
        {
            cboGrupos.SelectedItem = 0;
            cboUsuarios.SelectedItem = 0;
        }
        private void LimpiarGrupPermisos()
        {
            cboGrupos.SelectedItem = 0;
            cboGruposPer.SelectedItem = 0;
            chkAlta.Checked = false;
            chkBaja.Checked = false;
            chkModif.Checked = false;
            chkLectura.Checked = false;
        }
        private void btnAsiganrGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                 usu.AgregarGruposUsuarios(Convert.ToInt32(cboUsuarios.SelectedValue), Convert.ToInt32(cboGrupos.SelectedValue));
                 MensajeOK("El usuario fue agregado al grupo correctamente");
                 LimpiarUsuGrupo();
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }
        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                usu.AgregarGruposPermisos(Convert.ToInt32(cboGruposPer.SelectedValue), Convert.ToInt32(cboPermisos.SelectedValue), chkAlta.Checked, chkBaja.Checked, chkModif.Checked, chkLectura.Checked);
                MensajeOK("El permiso fue agregado correctamente");
                LimpiarGrupPermisos();
                MostrarGruposPermisos();
            }
            catch (Exception ex)
            {
                
                MensajeError(ex.Message);
            }
        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                usu.QuitarPermisos(Convert.ToInt32(lblId_grupoPermiso.Text));
                MensajeOK("El permiso fue quitado correctamente");
                MostrarGruposPermisos();
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }
        }

        private void dt_gruposPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId_grupoPermiso.Text = Convert.ToString(dt_gruposPermisos.CurrentRow.Cells["id_GrupoPermiso"].Value);
            cboGruposPer.Text = Convert.ToString(dt_gruposPermisos.CurrentRow.Cells["Grupo"].Value);
            cboPermisos.Text = Convert.ToString(dt_gruposPermisos.CurrentRow.Cells["Permiso"].Value);
            chkAlta.Checked = Convert.ToBoolean(dt_gruposPermisos.CurrentRow.Cells["alta"].Value);
            chkBaja.Checked = Convert.ToBoolean(dt_gruposPermisos.CurrentRow.Cells["baja"].Value);
            chkModif.Checked = Convert.ToBoolean(dt_gruposPermisos.CurrentRow.Cells["modificacion"].Value);
            chkLectura.Checked = Convert.ToBoolean(dt_gruposPermisos.CurrentRow.Cells["lectura"].Value);


        }

       

    
    }
}
