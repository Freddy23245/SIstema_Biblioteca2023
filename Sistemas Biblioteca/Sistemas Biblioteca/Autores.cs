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
    public partial class Autores : Form
    {

        public string id_autor1;
        public string nombre1;
        public bool flag;
        DataTable dt = new DataTable();
        lAutores autor = new lAutores();


        public Autores()
        {
            InitializeComponent();
        }
       
        private void mostrar()
        {
            dt = autor.mostrar();
            this.dt_autores.DataSource = dt;
            cboCampos.SelectedIndex = 0;
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
        private void Limpiar()
        {
            txt_id_autor.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_mail.Text = string.Empty;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            { 
          
                if(string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellido.Text) || string.IsNullOrEmpty(txt_mail.Text))
                {
                   
                    this.MensajeError("Asegurese de que los campos esten completos");
                }
                else
                {
                     autor.insertar(this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), this.txt_mail.Text.Trim());
                    this.MensajeOk("Se Agrego de forma correcta el registro");
                    Limpiar();
                    this.mostrar();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Autores_Load(object sender, EventArgs e)
        {
            this.mostrar();
            Botones();

           
           
        }

        private void dt_autores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == false)
            {
                this.txt_id_autor.Text = Convert.ToString(dt_autores.CurrentRow.Cells["id_autor"].Value);
                this.txt_nombre.Text = Convert.ToString(dt_autores.CurrentRow.Cells["nombre"].Value);
                this.txt_apellido.Text = Convert.ToString(dt_autores.CurrentRow.Cells["apellido"].Value);
                this.txt_mail.Text = Convert.ToString(dt_autores.CurrentRow.Cells["mail"].Value);
            }
           
               
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_id_autor.Text))
                {
                    MensajeError("Seleccione el regostro a modificar");
                }
                else
                {
                    if(string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellido.Text) || string.IsNullOrEmpty(txt_mail.Text))
                    {
                        MensajeError("Por favor complete los campos faltantes");
                    }
                    else
                    {
                        autor.editar(Convert.ToInt32(txt_id_autor.Text), txt_nombre.Text.Trim(), txt_apellido.Text, txt_mail.Text);
                        this.MensajeOk("Se Edito Correctamente");
                        Limpiar();
                        this.mostrar();
                    }
                }

                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
             try
            {


                if (string.IsNullOrEmpty(txt_id_autor.Text))
                {
                    MensajeError("Seleccione el regostro a modificar");
                }
                else
                {
                    autor.eliminar(Convert.ToInt32(this.txt_id_autor.Text));
                    this.MensajeOk("Se elimino de forma correcta el registro");
                    Limpiar();
                    this.mostrar();
                }
                
       
        }
            catch(Exception ex)
             {
                MessageBox.Show(ex.Message);
            }
    }

        private void dt_autores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libros form = (Libros)Owner;
            if(e.RowIndex == -1)
            {

            }
            else
            {
                DataGridViewRow dgv = dt_autores.Rows[e.RowIndex];
                if (this.flag == true)
                {
                    
                    form.txt_id_autor.Text = dgv.Cells[0].Value.ToString();
                    form.txt_nombre_autor.Text = dgv.Cells[1].Value.ToString();

                    //form.setAutor(par1, par2);
                    this.Hide();
                }
            }
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Salir de Registros de Autores?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                errorAutor.SetError(txt_nombre, "");
            }
            else
            {
                errorAutor.SetError(txt_nombre, "El Nombre Esta Vacio");
            }
        }

        private void txt_apellido_Validating(object sender, CancelEventArgs e)
        {
            if (txt_apellido.Text.Length > 0)
            {
                errorAutor.SetError(txt_apellido, "");
            }
            else
            {
                errorAutor.SetError(txt_apellido, "El apellido Esta Vacio");
            }
        }

        private void txt_mail_Validating(object sender, CancelEventArgs e)
        {
            if (txt_mail.Text.Length > 0)
            {
                errorAutor.SetError(txt_mail, "");
            }
            else
            {
                errorAutor.SetError(txt_mail, "El mail Esta Vacio");
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
            dt_autores.Visible = false;

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
                        dt_autores.Visible = true;
                }
            }

        }

        private void Buscar()
        {
            DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());
            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter = cboCampos.Text + " like'" + txtBuscar.Text + "%'";

            if (dv.Count != 0)
            {
                dt_autores.DataSource = dv;

            }
            else
            {
                dt_autores.DataSource = null;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }


 }
}
