using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Capa_Logica;

namespace Sistemas_Biblioteca
{
    public partial class Alumnos : Form
    {

        public string id_alumno1;
        public string nombre1;
        public bool flag;
        Lalumnos al = new Lalumnos();
        DataTable dt = new DataTable();
        public Alumnos()
        {
            InitializeComponent();
            this.txt_id.Visible = false;
        }

        private void limpiar()
        {
            this.txt_id.Text = string.Empty;
            this.txt_nombre.Text = string.Empty;
            this.txt_apellido.Text = string.Empty;
            this.txt_dni.Text = string.Empty;
            this.txt_telefono.Text = string.Empty;
            this.txt_direccion.Text = string.Empty;
            this.txt_mail.Text = string.Empty;
        }
        private void mostrar()
        {
            dt = al.mostrar();
            this.dt_alumnos.DataSource = dt;
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
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_dni.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_mail.Text = string.Empty; 
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            this.mostrar();
            Botones();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (!string.IsNullOrEmpty(txt_nombre.Text) && !string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_dni.Text) && !string.IsNullOrEmpty(txt_telefono.Text) && !string.IsNullOrEmpty(txt_direccion.Text) && !string.IsNullOrEmpty(txt_mail.Text))
                {
                    al.insertar(this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), txt_dni.Text.Trim(), txt_telefono.Text, txt_direccion.Text, txt_mail.Text);
                    this.MensajeOk("Se Agrego el registro de forma correcta el registro");
                    limpiar();
                    this.mostrar();

                }
                else
                {
                    this.MensajeError("Asegurese que todos los campos esten completos");
                }
               
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {

                if(string.IsNullOrEmpty(txt_id.Text))
                {
                    MensajeError("Por favor seleccione el registro a modificar");
                }
                else
                {
                    if(!string.IsNullOrEmpty(txt_nombre.Text) && !string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_dni.Text) && !string.IsNullOrEmpty(txt_telefono.Text) && !string.IsNullOrEmpty(txt_direccion.Text) && !string.IsNullOrEmpty(txt_mail.Text))
                    {
                        al.editar(Convert.ToInt32(this.txt_id.Text), this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), txt_dni.Text.Trim(), txt_telefono.Text.Trim(), txt_direccion.Text.Trim(), txt_mail.Text.Trim());
                        this.MensajeOk("Se Actualizo de forma correcta el registro");
                        limpiar();
                        this.mostrar();
                    }
                    else
                    {
                        this.MensajeError("Asegurese de que todos los campos esten completos");
                    }
                }
                    
             
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dt_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["id_alumno"].Value);
            this.txt_nombre.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["nombre"].Value);
            this.txt_apellido.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["apellido"].Value);
            this.txt_dni.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["dni"].Value);
            this.txt_telefono.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["telefono"].Value);
            this.txt_direccion.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["direccion"].Value);
            this.txt_mail.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["mail"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
             
                if(!string.IsNullOrEmpty(txt_id.Text))
                {
                    al.eliminar(Convert.ToInt32(txt_id.Text));
                    this.MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    this.mostrar();
                
                }
                else
                {
                    this.MensajeError("Seleccione el registro a eliminar");
                }
           
            }catch(Exception ex)
            {
                MessageBox.Show("Asegurese de que el alumno no tenga prestamos pendientes " + ex.Message);
            }
        }

        private void dt_alumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Prestamos prest = (Prestamos)Owner;
           if(e.RowIndex == -1)
           {

           }
           else
           {
               DataGridViewRow dgv = dt_alumnos.Rows[e.RowIndex];
               if (flag == true)
               {
                   prest.txt_id_alumno.Text = dgv.Cells[0].Value.ToString();
                   prest.txt_alumno.Text = dgv.Cells[1].Value.ToString();
                   this.Hide();
               }
           }
         
          

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;

            cons = MessageBox.Show("¿Desea Salir de Registros de Alumnos?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cons == DialogResult.Yes)
                this.Close();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_nombre, "");
            }
            else
            {
                errorAlumnos.SetError(txt_nombre, "El Nombre Esta Vacio");
            }
        }

        private void txt_apellido_Validating(object sender, CancelEventArgs e)
        {
            if (txt_apellido.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_apellido, "");
            }
            else
            {
                errorAlumnos.SetError(txt_apellido, "El Apellido Esta Vacio");
            }
        }

        private void txt_dni_Validating(object sender, CancelEventArgs e)
        {
            if (txt_dni.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_dni, "");
            }
            else
            {
                errorAlumnos.SetError(txt_dni, "El dni Esta Vacio");
            }
        }

        private void txt_telefono_Validating(object sender, CancelEventArgs e)
        {
            if (txt_telefono.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_telefono, "");
            }
            else
            {
                errorAlumnos.SetError(txt_telefono, "El telefono Esta Vacio");
            }
        }

        private void txt_direccion_Validating(object sender, CancelEventArgs e)
        {
            if (txt_telefono.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_telefono, "");
            }
            else
            {
                errorAlumnos.SetError(txt_telefono, "El direccion Esta Vacio");
            }
        }

        private void txt_mail_Validating(object sender, CancelEventArgs e)
        {
            if (txt_mail.Text.Length > 0)
            {
                errorAlumnos.SetError(txt_mail, "");
            }
            else
            {
                errorAlumnos.SetError(txt_mail, "El mail Esta Vacio");
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void Botones()
        {
            Lusuarios usu = new Lusuarios();
            DataTable dt;
            dt = usu.ValidatBotones(cache_usuario.Id_usuario);

            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            dt_alumnos.Visible = false;

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
                         dt_alumnos.Visible = true;
                 }
            }

        }
       
        private void Buscar()
        {
            DataSet ds = new DataSet();
            
            ds.Tables.Add(dt.Copy());
            DataView dv = new DataView(ds.Tables[0]);
            
            dv.RowFilter = cboCampos.Text + " like'" + txtBuscar.Text + "%'";

            if(dv.Count != 0)
            {
                
                dt_alumnos.DataSource = dv;

            }
            else
            {
                dt_alumnos.DataSource = null;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }


    }
}
