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
    public partial class Genero : Form
    {
        public string id_genero1;
        public string nombre1;
        public bool flag;
        Lgenero genero = new Lgenero();
        DataTable dt = new DataTable();
        public Genero()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            dt = genero.mostrar();
            this.dt_Genero.DataSource = dt;
           
        }
        private void Buscar()
        {
            DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());
            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter =  " nombre  like'" + txtBuscar.Text + "%'";

            if (dv.Count != 0)
            {
                dt_Genero.DataSource = dv;

            }
            else
            {
                dt_Genero.DataSource = null;
            }

        }
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Biblioteca",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            txt_id_genero.Text = string.Empty;
            txt_nombre.Text = string.Empty;
        }
        private void Genero_Load(object sender, EventArgs e)
        {
            this.mostrar();
            Botones();
        }

        private void Botones()
        {
            Lusuarios usu = new Lusuarios();
            DataTable dt;
            dt = usu.ValidatBotones(cache_usuario.Id_usuario);

            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            dt_Genero.Visible = false;

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
                        dt_Genero.Visible = true;
                }
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_nombre.Text))
          {
              MensajeError("Por favor agregue el nombre del genero");
          }
          else
          {
              genero.insertar(txt_nombre.Text.Trim());
              this.MensajeOK("El Genero Se Agrego Correctamente");
              Limpiar();
              this.mostrar();
          }
            }
            catch (Exception ex)
            {

                MensajeOK("El genero ya esta registrado " + ex.Message);
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                  if(string.IsNullOrEmpty(txt_id_genero.Text))
            {
                MensajeError("Por favor seleccione el registro a modificar");
            }
            else
            {
                genero.editar(Convert.ToInt32(txt_id_genero.Text), txt_nombre.Text);
                MensajeOK("El Genero Se Edito Correctamente");
                Limpiar();
                this.mostrar();
            }
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id_genero.Text = Convert.ToString(dt_Genero.CurrentRow.Cells["id_genero"].Value);
            this.txt_nombre.Text = Convert.ToString(dt_Genero.CurrentRow.Cells["nombre"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
                if(string.IsNullOrEmpty(txt_id_genero.Text))
                {
                    MensajeError("Por favor seleccione al registro a eliminar");
                }
                else
                {
                    genero.eliminar(Convert.ToInt32(txt_id_genero.Text));
                    MensajeOK("El Genero Se Elimino Correctamente");
                    Limpiar();
                    this.mostrar();
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
               DataGridViewRow dgv = dt_Genero.Rows[e.RowIndex];
               if (this.flag == true)
               {
                   form.txt_id_genero.Text = dgv.Cells[0].Value.ToString();
                   form.txt_genero.Text = dgv.Cells[1].Value.ToString();
                   this.Hide();
               }
           
           }
        }

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                errorGenero.SetError(txt_nombre, "");
            }
            else
            {
                errorGenero.SetError(txt_nombre, "El Nombre Esta Vacio");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Salir de Registros de Generos?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
