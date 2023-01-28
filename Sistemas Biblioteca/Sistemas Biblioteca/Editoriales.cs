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
    public partial class Editoriales : Form
    {
        public string id_editorial1;
        public string nombre1;
        public bool flag;
        Leditoriales editorial = new Leditoriales();
        DataTable dt = new DataTable();

        public Editoriales()
        {
            InitializeComponent();
        }
            
        private void mostrar()
        {
            dt = editorial.mostrar();
            this.dt_Editorial.DataSource = dt;
            cboCampos.SelectedIndex = 0;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistemas Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarPaises()
        {
            DataTable dt;
            dt = editorial.mostrarPeises();
            cbxPaises.DataSource = dt;
            cbxPaises.ValueMember = "id_pais";
            cbxPaises.DisplayMember = "nombre";
        }

        private void Editoriales_Load(object sender, EventArgs e)
        {
            mostrar();
            Botones();
            MostrarPaises();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre_ed.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbxPaises.SelectedItem = 0;
            txtSitioWeb.Text = string.Empty;
        }
        private void Buscar()
        {
            DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());
            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter = cboCampos.Text + " like'" + txtBuscar.Text + "%'";

            if (dv.Count != 0)
            {
                dt_Editorial .DataSource = dv;

            }
            else
            {
                dt_Editorial.DataSource = null;
            }

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try
            {
                if(string.IsNullOrEmpty(txt_nombre_ed.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSitioWeb.Text))
            {
                MensajeError("Por favor verifique que todos los campos esten completos");

            }
            else
            {
                editorial.insertar(txt_nombre_ed.Text.Trim(),txtEmail.Text,Convert.ToInt32(cbxPaises.SelectedValue),txtSitioWeb.Text);
                this.MensajeOk("Se agrego de forma correcta el registro");
                Limpiar();
                this.mostrar();
            }
            }
            catch (Exception ex)
            {

                MensajeError("La editorial ya esta registrada " + ex.Message);
            }

          }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_id.Text) )
            {
                MensajeError("Por favor seleccione el  registro a modificar");
            }else
            {
                if (string.IsNullOrEmpty(txt_nombre_ed.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSitioWeb.Text))
                {
                    MensajeError("Por favor verifique que todos los campos esten completos");

                }
                else
                {
                    editorial.editar(Convert.ToInt32(txt_id.Text), txt_nombre_ed.Text.Trim(), txtEmail.Text, Convert.ToInt32(cbxPaises.SelectedValue), txtSitioWeb.Text);
                    this.MensajeOk("Se modifico de forma correcta el registro");
                    Limpiar();
                    this.mostrar();
                }
            }
            
            
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id.Text = Convert.ToString(dt_Editorial.CurrentRow.Cells["id_editorial"].Value);
            this.txt_nombre_ed.Text = Convert.ToString(dt_Editorial.CurrentRow.Cells["nombre"].Value);
            this.txtEmail.Text = Convert.ToString(dt_Editorial.CurrentRow.Cells["email"].Value);
            this.cbxPaises.Text = Convert.ToString(dt_Editorial.CurrentRow.Cells["pais"].Value);
            this.txtSitioWeb.Text = Convert.ToString(dt_Editorial.CurrentRow.Cells["sitio_web"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
               if(string.IsNullOrEmpty(txt_id.Text))
                {
                MensajeError("Por favor seleccione el registro a eliminar");
                }
                else
                {
                   editorial.eliminar(Convert.ToInt32(txt_id.Text));
                   MensajeOk("Datos Eliminados Correctamente");
                   Limpiar();
                   mostrar();
                }


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libros form = (Libros)Owner;
          if(e.RowIndex == -1)
          {

          }
          else
          {
              DataGridViewRow dgv = dt_Editorial.Rows[e.RowIndex];
              if (this.flag == true)
              {
                  form.txt_id_editorial.Text = dgv.Cells[0].Value.ToString();
                  form.txt_editorial.Text = dgv.Cells[1].Value.ToString();
                  this.Hide();
              }
          }
            

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Salir de Registros de Editoriales?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void txt_nombre_ed_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre_ed.Text.Length > 0)
            {
                errorEditorial.SetError(txt_nombre_ed, "");
            }
            else
            {
                errorEditorial.SetError(txt_nombre_ed, "El Nombre Esta Vacio");
            }
        }


        private void Botones()
        {
            Lusuarios usu = new Lusuarios();
            DataTable dt;
            dt = usu.ValidatBotones(cache_usuario.Id_usuario);

            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            dt_Editorial.Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["nombre"].ToString().Equals("Alumnos"))
                {
                    if (dt.Rows[i]["alta"].ToString().Equals("True"))
                        btn_agregar.Enabled = true;
                    if (dt.Rows[i]["modificacion"].ToString().Equals("True"))
                        btn_editar.Enabled = true;
                    if (dt.Rows[i]["baja"].ToString().Equals("True"))
                        btn_eliminar.Enabled = true;
                    if (dt.Rows[i]["lectura"].ToString().Equals("True"))
                        dt_Editorial.Visible = true;
                }
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }


        }
    }

