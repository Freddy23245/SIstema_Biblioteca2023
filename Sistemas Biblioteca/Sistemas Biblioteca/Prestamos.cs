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
    public partial class Prestamos : Form
    {
        Lprestar prestar = new Lprestar();
        DataTable dt = new DataTable();
        public Prestamos()
        {
            InitializeComponent();
        }
        Inicio ini = new Inicio();
        private void ocultarColumnas()
        {
            this.dt_prestamo.Columns[1].Visible = false;
            this.dt_prestamo.Columns[2].Visible = false;
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
                dt_prestamo.DataSource = dv;
                ocultarColumnas();
            }
            else
            {
                dt_prestamo.DataSource = null;
            }
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }

        }
        private void mostrarse()
        {
            dt = prestar.mostrar();
            this.dt_prestamo.DataSource = dt;
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

        private void btn_traer_alumno_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.flag = true;
            alumno.dt_alumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            alumno.gbxBuscador.Visible = false;
            alumno.gbxCampos.Visible = false;

            AddOwnedForm(alumno);
            alumno.FormBorderStyle = FormBorderStyle.None;
            alumno.TopLevel = false;
            alumno.Dock = DockStyle.Fill;
            this.Controls.Add(alumno);
            this.Tag = alumno;
            alumno.BringToFront();
            alumno.Show();

        }

        private void dt_prestamo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Comprobante com = new Comprobante();

            com.id_alumno = Convert.ToInt32(this.dt_prestamo.CurrentRow.Cells["id_alumno"].Value);
            com.ShowDialog();
        }
        private void Limpiar()
        {
            this.txt_id_prestamo.Text = string.Empty;
            this.txt_id_prestamo.Text = string.Empty;
            this.txt_id_alumno.Text = string.Empty;
            this.txt_alumno.Text = string.Empty;
            this.txt_id_libro.Text = string.Empty;
            this.txt_libro.Text = string.Empty;
        }
        private void dt_prestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id_prestamo.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_prestamo"].Value);
            this.txt_id_alumno.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_alumno"].Value);
            this.txt_alumno.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["Alumno"].Value);
            this.txt_id_libro.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_libro"].Value);
            this.txt_libro.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["Libro"].Value);
           
            this.dtp_max_prest.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["fecha_max_dev"].Value);

        


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_id_alumno.Text == string.Empty || txt_id_libro.Text == string.Empty)
            {
                MensajeError("Por favor asegurese de que todos los campos esten completos");
            }else
            {
                try
                {
                    if(VerificarLector())
                    {
                         DialogResult cons;
                         cons = MessageBox.Show("El Alumno tiene libros pendientes¿Desea Prestarle otro libro mas?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         if (cons == DialogResult.Yes)
                         {
                             prestar.insertar(Convert.ToInt32(txt_id_alumno.Text), Convert.ToInt32(txt_id_libro.Text), dtp_max_prest.Value);

                             MensajeOk("El Prestamo se agrego Correctamente");
                             Limpiar();
                             this.mostrarse();
                         }
                    }else
                    {
                        prestar.insertar(Convert.ToInt32(txt_id_alumno.Text), Convert.ToInt32(txt_id_libro.Text), dtp_max_prest.Value);

                        MensajeOk("El Prestamo se agrego Correctamente");
                        Limpiar();
                        this.mostrarse();
                    }
                    
                    
                }
                catch (Exception ex)
                {
                   
                    MensajeError("El Prestamo No Se agrego o el Libro no esta disponible" + ex.Message);
                }
            }

        }
            
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_id_prestamo.Text == string.Empty)
            {
                MensajeError("Por favor seleccione el prestamo a retornar");
            }else
            {
              
                try
                {
                    prestar.editar(Convert.ToInt32(txt_id_prestamo.Text), Convert.ToInt32(txt_id_alumno.Text), Convert.ToInt32(txt_id_libro.Text), dtp_max_prest.Value);
                        MensajeOk("El Prestamo Se Edito Correctamente");
                        Limpiar();
                        this.mostrarse();
             
                }
                catch (Exception ex)
                {
                     MensajeError("El Prestamo No Se Edito Correcatamente " + ex.Message);
                }
            }
           

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            this.mostrarse();
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
            btn_retornar.Enabled = false;
            dt_prestamo.Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["nombre"].ToString().Equals("Alumnos"))
                {
                    if (dt.Rows[i]["alta"].ToString().Equals("True"))
                        btn_agregar.Enabled = true;
                    if (dt.Rows[i]["modificacion"].ToString().Equals("True"))
                        btn_editar.Enabled = true;
                    if (dt.Rows[i]["baja"].ToString().Equals("True"))
                    {
                        btn_eliminar.Enabled = true;
                        btn_retornar.Enabled = true;
                    }
                        
                    if (dt.Rows[i]["lectura"].ToString().Equals("True"))
                        dt_prestamo.Visible = true;
                }
            }

        }


        private void btn_traer_libro_Click(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            libro.flag = true;
            libro.dt_libro.Dock = System.Windows.Forms.DockStyle.Fill;
            libro.gbxBuscador.Visible = false;
            libro.gbxCamposs.Visible = false;

            AddOwnedForm(libro);
            libro.FormBorderStyle = FormBorderStyle.None;
            libro.TopLevel = false;
            libro.Dock = DockStyle.Fill;
            this.Controls.Add(libro);
            this.Tag = libro;
            libro.BringToFront();
            libro.Show();


        }
        public bool VerificarLector()
        {
            try
            {
                //string rpta = "";
                DataTable resultado;
                Lprestar al = new Lprestar();
                resultado = prestar.mostrar_deuda(Convert.ToInt32(txt_id_alumno.Text));

                //resultado = FuncLector.VerificarLector(DatLector);

                if (resultado.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        


        private void btn_retornar_Click(object sender, EventArgs e)
        {

            if (txt_id_prestamo.Text == string.Empty)
            {
                MensajeError("Seleccione Prestamo Para Retornar");
            }else
            {

                try
                {
                prestar.retornar(Convert.ToInt32(txt_id_prestamo.Text),Convert.ToInt32(txt_id_libro.Text));
                MensajeOk("Se Retorno Correctamente");
                Limpiar();
                this.mostrarse();
                }
                catch (Exception ex )
                {

                    MensajeError("El libro no se retorno " + ex.Message);
                }
            

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(txt_id_prestamo.Text==string.Empty)
            {
               MensajeError("Seleccione Prestamo Para Eliminar");
            }else
            {

                try
                {
                prestar.eliminar(Convert.ToInt32(txt_id_prestamo.Text));
                    MensajeOk("El Prestamo Se Elimino Correcatamente");
                    Limpiar();
                    this.mostrarse();
                }
                catch (Exception ex )
                {
                    MensajeError("El Prestamo No Se ELimino " + ex.Message);
                   
                }

              }

        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            Comprobante com = new Comprobante();

            com.id_alumno = Convert.ToInt32(this.dt_prestamo.CurrentRow.Cells["id_alumno"].Value);
            com.ShowDialog();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult cons;
            cons = MessageBox.Show("¿Desea Salir de la Seccion de Prestamos?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cons == DialogResult.Yes)
                this.Close();
        }

        private void txt_id_alumno_Validating(object sender, CancelEventArgs e)
        {
            if (txt_id_alumno.Text.Length > 0)
            {
                errorPrestamos.SetError(txt_alumno, "");
            }
            else
            {
                errorPrestamos.SetError(txt_alumno, "El campo alumno  Esta Vacio");
            }
        }

        private void txt_id_libro_Validating(object sender, CancelEventArgs e)
        {
            if (txt_id_libro.Text.Length > 0)
            {
                errorPrestamos.SetError(txt_libro, "");
            }
            else
            {
                errorPrestamos.SetError(txt_libro, "El el campo libro Esta Vacio");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dt_prestamo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dt_prestamo.Columns[e.ColumnIndex].Name == "Multa")
            {
                if(e.Value != null)
                {
                    if(e.Value.GetType() != typeof(System.DBNull))
                    {
                        if(Convert.ToInt32(e.Value) < 0)
                        {
                            e.Value = 0;
                        }
                    }
                }
            }
            if(this.dt_prestamo.Columns[e.ColumnIndex].Name == "Estado_Prestamo")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (e.Value.ToString() == "Retornado")
                        {
                            e.CellStyle.BackColor = Color.SeaGreen;
                        }
                        if (e.Value.ToString() == "Pendiente")
                        {
                            e.CellStyle.BackColor = Color.Salmon;
                        }
                       
                       
                    }
                }
            }
        }


        
    }
}
