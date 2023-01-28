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
    public partial class Libros : Form
    {
        public string id_libro1;
        public string nombre1;
        public bool flag;
        Llibros libros = new Llibros();
        DataTable dt = new DataTable();
        Inicio ini = new Inicio();

        public Libros()
        {
            InitializeComponent();
        }
        private void ocultarColumnas()
        {
            this.dt_libro.Columns[1].Visible = false;
            this.dt_libro.Columns[2].Visible = false;
            this.dt_libro.Columns[3].Visible = false;
        }
        private void Limpiar()
        {
            txt_nombre.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txt_id_autor.Text = string.Empty;
            txt_nombre_autor.Text = string.Empty;
            txt_id_editorial.Text = string.Empty;
            txt_editorial.Text = string.Empty;
            txt_id_autor.Text = string.Empty;
            txt_nombre_autor.Text = string.Empty;
            txt_genero.Text = string.Empty;
            txt_genero.Text = string.Empty;
            txtIdioma.Text = string.Empty;
            cbx_estado.SelectedItem = 0;
            txt_id_genero.Text = string.Empty;
                
        }
        private void Buscar()
        {
            try
            {
                DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());
            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter = cboCampos.Text + " like'" + txtBuscar.Text + "%'";

            if (dv.Count != 0)
            {
                
                dt_libro.DataSource = dv;
               ocultarColumnas();
               

            }
            else
            {
                dt_libro.DataSource = null;
               
            }
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }

        }
        private void mostrar()
        {
            dt = libros.mostrar();
            dt_libro.DataSource = dt;
            cboCampos.SelectedIndex = 0;
            ocultarColumnas();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
        private void btn_traer_autor_Click(object sender, EventArgs e)
        {

            Autores frm_autor = new Autores();

            frm_autor.flag = true;
            frm_autor.gbxBuscador.Visible = false;
            frm_autor.gbxCamposs.Visible = false;
            frm_autor.dt_autores.Dock = System.Windows.Forms.DockStyle.Fill;

            AddOwnedForm(frm_autor);
            frm_autor.FormBorderStyle = FormBorderStyle.None;
            frm_autor.TopLevel = false;
            frm_autor.Dock = DockStyle.Fill;
            this.Controls.Add(frm_autor);
            this.Tag = frm_autor;
            frm_autor.BringToFront();
            frm_autor.Show();
            
        }

        private void btn_traer_gen_Click(object sender, EventArgs e)
        {
            Genero gen = new Genero();
            gen.flag = true;
            gen.dt_Genero.Dock = System.Windows.Forms.DockStyle.Fill;
            gen.gbxBuscador.Visible = false;
            gen.gbxCamposs.Visible = false;

            AddOwnedForm(gen);
            gen.FormBorderStyle = FormBorderStyle.None;
            gen.TopLevel = false;
            gen.Dock = DockStyle.Fill;
            this.Controls.Add(gen);
            this.Tag = gen;
            gen.BringToFront();
            gen.Show();
            

        }

        private void btn_traer_edit_Click(object sender, EventArgs e)
        {
            Editoriales edit = new Editoriales();
            edit.flag = true;
            edit.dt_Editorial.Dock = System.Windows.Forms.DockStyle.Fill;
            edit.gbxBuscador.Visible = false;
            edit.gbxCamposs.Visible = false;

            AddOwnedForm(edit);
            edit.FormBorderStyle = FormBorderStyle.None;
            edit.TopLevel = false;
            edit.Dock = DockStyle.Fill;
            this.Controls.Add(edit);
            this.Tag = edit;
            edit.BringToFront();
            edit.Show();
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(string.IsNullOrEmpty(txt_id_autor.Text) || string.IsNullOrEmpty(txt_id_genero.Text) || string.IsNullOrEmpty(txt_id_editorial.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtIdioma.Text))
                {
                    MensajeError("Por favor complete los campos obligatorios");
                }
                else
                {
                    libros.insetar(Convert.ToInt32(txt_id_autor.Text), Convert.ToInt32(txt_id_genero.Text), Convert.ToInt32(txt_id_editorial.Text), txt_nombre.Text,txtISBN.Text, dtp_añop.Value,txtIdioma.Text,Convert.ToInt32(cbx_estado.SelectedValue));//estado
                    MensajeOk("Se agrego el libro Correctamente");
                    Limpiar();
                    this.mostrar();
                }
              


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void mostrarEstados()
        {
            DataTable dt;
            dt = libros.mostrarEstado();
            cbx_estado.DataSource = dt;
            cbx_estado.ValueMember = "id_estado";
            cbx_estado.DisplayMember = "estado";
        }
        private void Libros_Load(object sender, EventArgs e)
        {
            this.mostrar();
            Botones();
            mostrarEstados();
        }

        private void Botones()
        {
            Lusuarios usu = new Lusuarios();
            DataTable dt;
            dt = usu.ValidatBotones(cache_usuario.Id_usuario);

            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            dt_libro.Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["nombre"].ToString().Equals("Libros"))
                {
                    if (dt.Rows[i]["alta"].ToString().Equals("True"))
                        btn_agregar.Enabled = true;
                    if (dt.Rows[i]["modificacion"].ToString().Equals("True"))
                        btn_editar.Enabled = true;
                    if (dt.Rows[i]["baja"].ToString().Equals("True"))
                        btn_eliminar.Enabled = true;
                    if (dt.Rows[i]["lectura"].ToString().Equals("True"))
                        dt_libro.Visible = true;
                }
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_idlibro.Text))
            {
                MensajeError("Por favor seleccione el libro a modificar");
            }
            else
            {
                if (string.IsNullOrEmpty(txt_id_autor.Text) || string.IsNullOrEmpty(txt_id_genero.Text) || string.IsNullOrEmpty(txt_id_editorial.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtIdioma.Text))
                {
                    MensajeError("Por favor complete los campos");
                }
                else
                {
                    libros.editar(Convert.ToInt32(txt_idlibro.Text), Convert.ToInt32(txt_id_autor.Text), Convert.ToInt32(txt_id_genero.Text), Convert.ToInt32(txt_id_editorial.Text), txt_nombre.Text,txtISBN.Text, dtp_añop.Value,txtIdioma.Text,Convert.ToInt32(cbx_estado.SelectedValue));
                    MensajeOk("EL Libro Se Edito Correctamente");
                    Limpiar();
                    this.mostrar();
                }

            }
          

        }

        private void dt_libro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_idlibro.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_libro"].Value);
            this.txt_id_autor.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_autor"].Value);
            this.txt_id_genero.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_genero"].Value);
            this.txt_id_editorial.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_editorial"].Value);
            this.txt_nombre.Text = Convert.ToString(dt_libro.CurrentRow.Cells["nombre"].Value);
            this.dtp_añop.Text = Convert.ToString(dt_libro.CurrentRow.Cells["año_publicacion"].Value);
            this.cbx_estado.Text = Convert.ToString(dt_libro.CurrentRow.Cells["estado"].Value);
            this.txt_nombre_autor.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Autor"].Value);
            this.txt_genero.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Genero"].Value);
            this.txt_editorial.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Editorial"].Value);
            this.txtIdioma.Text = Convert.ToString(dt_libro.CurrentRow.Cells["idioma"].Value);
            this.txtISBN.Text = Convert.ToString(dt_libro.CurrentRow.Cells["ISBN"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_idlibro.Text))
            {
                MensajeError("Por favor seleccione el libro a eliminar");
               
            }
            else
            {

                libros.eliminar(Convert.ToInt32(txt_idlibro.Text));
                MensajeOk("El Libro Se Elimino Correctamente");
                Limpiar();
                this.mostrar();
            }

        }

        private void dt_libro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Prestamos prest = (Prestamos)Owner;
            if(e.RowIndex == -1)
            {

            }
            else
            {
                DataGridViewRow dgv = dt_libro.Rows[e.RowIndex];
                if (this.flag == true)
                {
                    prest.txt_id_libro.Text = dgv.Cells[0].Value.ToString();
                    prest.txt_libro.Text = dgv.Cells[5].Value.ToString();

                    //form.setAutor(par1, par2);
                    this.Hide();
                } 
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;
            cons = MessageBox.Show("¿Desea Salir de Registros de Libros?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void gbxContenedor_Enter(object sender, EventArgs e)
        {

        }

        private void dt_libro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dt_libro.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (e.Value.ToString() == "Disponible")
                        {
                            e.CellStyle.BackColor = Color.SeaGreen;
                        }
                        if (e.Value.ToString() == "Prestado")
                        {
                            e.CellStyle.BackColor = Color.DarkOrange;
                        }
                        if (e.Value.ToString() == "Fuera de Uso")
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        if (e.Value.ToString() == "En Reparacion")
                        {
                            e.CellStyle.BackColor = Color.Gray;
                        }
                    }
                }
            }
        }
}
    

}
