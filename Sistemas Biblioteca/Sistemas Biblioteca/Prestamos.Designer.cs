namespace Sistemas_Biblioteca
{
    partial class Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_prestamo = new System.Windows.Forms.TextBox();
            this.txt_id_alumno = new System.Windows.Forms.TextBox();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.txt_libro = new System.Windows.Forms.TextBox();
            this.txt_id_libro = new System.Windows.Forms.TextBox();
            this.dtp_prestamo = new System.Windows.Forms.DateTimePicker();
            this.btn_traer_libro = new System.Windows.Forms.Button();
            this.btn_traer_alumno = new System.Windows.Forms.Button();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.errorPrestamos = new System.Windows.Forms.ErrorProvider(this.components);
            this.dt_prestamo = new System.Windows.Forms.DataGridView();
            this.dtp_max_prest = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboCampos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_agregar.Location = new System.Drawing.Point(31, 189);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(92, 30);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_editar.Location = new System.Drawing.Point(142, 189);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(92, 30);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libro a Prestar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Prestamo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Devolucion:";
            // 
            // txt_id_prestamo
            // 
            this.txt_id_prestamo.Location = new System.Drawing.Point(835, 12);
            this.txt_id_prestamo.Name = "txt_id_prestamo";
            this.txt_id_prestamo.Size = new System.Drawing.Size(100, 20);
            this.txt_id_prestamo.TabIndex = 7;
            this.txt_id_prestamo.Visible = false;
            // 
            // txt_id_alumno
            // 
            this.txt_id_alumno.Enabled = false;
            this.txt_id_alumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_alumno.Location = new System.Drawing.Point(158, 62);
            this.txt_id_alumno.MaxLength = 5;
            this.txt_id_alumno.Name = "txt_id_alumno";
            this.txt_id_alumno.Size = new System.Drawing.Size(41, 23);
            this.txt_id_alumno.TabIndex = 8;
            this.txt_id_alumno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_id_alumno_Validating);
            // 
            // txt_alumno
            // 
            this.txt_alumno.Enabled = false;
            this.txt_alumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alumno.Location = new System.Drawing.Point(158, 62);
            this.txt_alumno.MaxLength = 50;
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.Size = new System.Drawing.Size(213, 23);
            this.txt_alumno.TabIndex = 9;
            // 
            // txt_libro
            // 
            this.txt_libro.Enabled = false;
            this.txt_libro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_libro.Location = new System.Drawing.Point(158, 87);
            this.txt_libro.MaxLength = 50;
            this.txt_libro.Name = "txt_libro";
            this.txt_libro.Size = new System.Drawing.Size(213, 23);
            this.txt_libro.TabIndex = 11;
            // 
            // txt_id_libro
            // 
            this.txt_id_libro.Enabled = false;
            this.txt_id_libro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_libro.Location = new System.Drawing.Point(158, 88);
            this.txt_id_libro.MaxLength = 5;
            this.txt_id_libro.Name = "txt_id_libro";
            this.txt_id_libro.Size = new System.Drawing.Size(41, 23);
            this.txt_id_libro.TabIndex = 10;
            this.txt_id_libro.Validating += new System.ComponentModel.CancelEventHandler(this.txt_id_libro_Validating);
            // 
            // dtp_prestamo
            // 
            this.dtp_prestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_prestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_prestamo.Location = new System.Drawing.Point(158, 112);
            this.dtp_prestamo.Name = "dtp_prestamo";
            this.dtp_prestamo.Size = new System.Drawing.Size(213, 23);
            this.dtp_prestamo.TabIndex = 12;
            // 
            // btn_traer_libro
            // 
            this.btn_traer_libro.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_traer_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer_libro.Location = new System.Drawing.Point(375, 90);
            this.btn_traer_libro.Name = "btn_traer_libro";
            this.btn_traer_libro.Size = new System.Drawing.Size(39, 23);
            this.btn_traer_libro.TabIndex = 15;
            this.btn_traer_libro.Text = "...";
            this.btn_traer_libro.UseVisualStyleBackColor = false;
            this.btn_traer_libro.Click += new System.EventHandler(this.btn_traer_libro_Click);
            // 
            // btn_traer_alumno
            // 
            this.btn_traer_alumno.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_traer_alumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer_alumno.Location = new System.Drawing.Point(375, 62);
            this.btn_traer_alumno.Name = "btn_traer_alumno";
            this.btn_traer_alumno.Size = new System.Drawing.Size(39, 23);
            this.btn_traer_alumno.TabIndex = 16;
            this.btn_traer_alumno.Text = "...";
            this.btn_traer_alumno.UseVisualStyleBackColor = false;
            this.btn_traer_alumno.Click += new System.EventHandler(this.btn_traer_alumno_Click);
            // 
            // btn_retornar
            // 
            this.btn_retornar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_retornar.FlatAppearance.BorderSize = 0;
            this.btn_retornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retornar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_retornar.Location = new System.Drawing.Point(259, 189);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(92, 30);
            this.btn_retornar.TabIndex = 17;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = false;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.Location = new System.Drawing.Point(292, 544);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(112, 33);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_comprobante.FlatAppearance.BorderSize = 0;
            this.btn_comprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_comprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprobante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobante.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_comprobante.Location = new System.Drawing.Point(82, 357);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(223, 68);
            this.btn_comprobante.TabIndex = 19;
            this.btn_comprobante.Text = "Comprobante";
            this.btn_comprobante.UseVisualStyleBackColor = false;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1084, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 20;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // errorPrestamos
            // 
            this.errorPrestamos.ContainerControl = this;
            // 
            // dt_prestamo
            // 
            this.dt_prestamo.AllowUserToAddRows = false;
            this.dt_prestamo.AllowUserToDeleteRows = false;
            this.dt_prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_prestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dt_prestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_prestamo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dt_prestamo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_prestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_prestamo.ColumnHeadersHeight = 30;
            this.dt_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_prestamo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_prestamo.EnableHeadersVisualStyles = false;
            this.dt_prestamo.GridColor = System.Drawing.Color.SteelBlue;
            this.dt_prestamo.Location = new System.Drawing.Point(442, 107);
            this.dt_prestamo.Name = "dt_prestamo";
            this.dt_prestamo.ReadOnly = true;
            this.dt_prestamo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_prestamo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dt_prestamo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_prestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_prestamo.Size = new System.Drawing.Size(662, 470);
            this.dt_prestamo.TabIndex = 21;
            this.dt_prestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_prestamo_CellContentClick);
            this.dt_prestamo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_prestamo_CellContentDoubleClick);
            this.dt_prestamo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_prestamo_CellFormatting);
            // 
            // dtp_max_prest
            // 
            this.dtp_max_prest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_max_prest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_max_prest.Location = new System.Drawing.Point(158, 137);
            this.dtp_max_prest.Name = "dtp_max_prest";
            this.dtp_max_prest.Size = new System.Drawing.Size(213, 23);
            this.dtp_max_prest.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(625, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(835, 65);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(141, 23);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cboCampos
            // 
            this.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.Items.AddRange(new object[] {
            "Alumno",
            "dni",
            "Libro",
            "fecha_prestamo",
            "fecha_max_dev",
            "fecha_devolucion"});
            this.cboCampos.Location = new System.Drawing.Point(710, 64);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(121, 24);
            this.cboCampos.TabIndex = 25;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1116, 658);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboCampos);
            this.Controls.Add(this.dtp_max_prest);
            this.Controls.Add(this.dt_prestamo);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(this.btn_traer_alumno);
            this.Controls.Add(this.btn_traer_libro);
            this.Controls.Add(this.dtp_prestamo);
            this.Controls.Add(this.txt_libro);
            this.Controls.Add(this.txt_id_libro);
            this.Controls.Add(this.txt_alumno);
            this.Controls.Add(this.txt_id_alumno);
            this.Controls.Add(this.txt_id_prestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_prestamo;
        private System.Windows.Forms.DateTimePicker dtp_prestamo;
        private System.Windows.Forms.Button btn_traer_libro;
        private System.Windows.Forms.Button btn_traer_alumno;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_comprobante;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.ErrorProvider errorPrestamos;
        private System.Windows.Forms.DataGridView dt_prestamo;
        private System.Windows.Forms.DateTimePicker dtp_max_prest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboCampos;
        public System.Windows.Forms.TextBox txt_id_alumno;
        public System.Windows.Forms.TextBox txt_alumno;
        public System.Windows.Forms.TextBox txt_libro;
        public System.Windows.Forms.TextBox txt_id_libro;
    }
}