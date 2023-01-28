namespace Sistemas_Biblioteca
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_idlibro = new System.Windows.Forms.TextBox();
            this.txt_id_autor = new System.Windows.Forms.TextBox();
            this.txt_nombre_autor = new System.Windows.Forms.TextBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.txt_id_genero = new System.Windows.Forms.TextBox();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.txt_id_editorial = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dtp_añop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_traer_autor = new System.Windows.Forms.Button();
            this.btn_traer_gen = new System.Windows.Forms.Button();
            this.btn_traer_edit = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.dt_libro = new System.Windows.Forms.DataGridView();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboCampos = new System.Windows.Forms.ComboBox();
            this.gbxContenedor = new System.Windows.Forms.GroupBox();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.gbxCamposs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_libro)).BeginInit();
            this.gbxContenedor.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            this.gbxCamposs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_idlibro
            // 
            this.txt_idlibro.Location = new System.Drawing.Point(570, 421);
            this.txt_idlibro.Name = "txt_idlibro";
            this.txt_idlibro.Size = new System.Drawing.Size(100, 20);
            this.txt_idlibro.TabIndex = 0;
            // 
            // txt_id_autor
            // 
            this.txt_id_autor.Enabled = false;
            this.txt_id_autor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_autor.Location = new System.Drawing.Point(160, 97);
            this.txt_id_autor.MaxLength = 5;
            this.txt_id_autor.Name = "txt_id_autor";
            this.txt_id_autor.Size = new System.Drawing.Size(57, 23);
            this.txt_id_autor.TabIndex = 1;
            this.txt_id_autor.Visible = false;
            // 
            // txt_nombre_autor
            // 
            this.txt_nombre_autor.Enabled = false;
            this.txt_nombre_autor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_autor.Location = new System.Drawing.Point(160, 97);
            this.txt_nombre_autor.MaxLength = 30;
            this.txt_nombre_autor.Name = "txt_nombre_autor";
            this.txt_nombre_autor.Size = new System.Drawing.Size(239, 23);
            this.txt_nombre_autor.TabIndex = 2;
            // 
            // txt_genero
            // 
            this.txt_genero.Enabled = false;
            this.txt_genero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genero.Location = new System.Drawing.Point(160, 123);
            this.txt_genero.MaxLength = 30;
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(239, 23);
            this.txt_genero.TabIndex = 4;
            // 
            // txt_id_genero
            // 
            this.txt_id_genero.Enabled = false;
            this.txt_id_genero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_genero.Location = new System.Drawing.Point(160, 123);
            this.txt_id_genero.MaxLength = 5;
            this.txt_id_genero.Name = "txt_id_genero";
            this.txt_id_genero.Size = new System.Drawing.Size(57, 23);
            this.txt_id_genero.TabIndex = 3;
            this.txt_id_genero.Visible = false;
            // 
            // txt_editorial
            // 
            this.txt_editorial.Enabled = false;
            this.txt_editorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editorial.Location = new System.Drawing.Point(160, 149);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(239, 23);
            this.txt_editorial.TabIndex = 6;
            // 
            // txt_id_editorial
            // 
            this.txt_id_editorial.Enabled = false;
            this.txt_id_editorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_editorial.Location = new System.Drawing.Point(160, 149);
            this.txt_id_editorial.Name = "txt_id_editorial";
            this.txt_id_editorial.Size = new System.Drawing.Size(57, 23);
            this.txt_id_editorial.TabIndex = 5;
            this.txt_id_editorial.Visible = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(160, 18);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(239, 23);
            this.txt_nombre.TabIndex = 7;
            // 
            // dtp_añop
            // 
            this.dtp_añop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_añop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_añop.Location = new System.Drawing.Point(160, 71);
            this.dtp_añop.Name = "dtp_añop";
            this.dtp_añop.Size = new System.Drawing.Size(239, 23);
            this.dtp_añop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(106, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(88, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(85, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Editorial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(86, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(1, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Año De Publicacion:";
            // 
            // btn_traer_autor
            // 
            this.btn_traer_autor.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_traer_autor.FlatAppearance.BorderSize = 0;
            this.btn_traer_autor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_traer_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer_autor.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_traer_autor.Location = new System.Drawing.Point(405, 98);
            this.btn_traer_autor.Name = "btn_traer_autor";
            this.btn_traer_autor.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_autor.TabIndex = 16;
            this.btn_traer_autor.Text = "...";
            this.btn_traer_autor.UseVisualStyleBackColor = false;
            this.btn_traer_autor.Click += new System.EventHandler(this.btn_traer_autor_Click);
            // 
            // btn_traer_gen
            // 
            this.btn_traer_gen.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_traer_gen.FlatAppearance.BorderSize = 0;
            this.btn_traer_gen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_traer_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer_gen.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_traer_gen.Location = new System.Drawing.Point(405, 125);
            this.btn_traer_gen.Name = "btn_traer_gen";
            this.btn_traer_gen.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_gen.TabIndex = 17;
            this.btn_traer_gen.Text = "...";
            this.btn_traer_gen.UseVisualStyleBackColor = false;
            this.btn_traer_gen.Click += new System.EventHandler(this.btn_traer_gen_Click);
            // 
            // btn_traer_edit
            // 
            this.btn_traer_edit.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_traer_edit.FlatAppearance.BorderSize = 0;
            this.btn_traer_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_traer_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traer_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traer_edit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_traer_edit.Location = new System.Drawing.Point(405, 154);
            this.btn_traer_edit.Name = "btn_traer_edit";
            this.btn_traer_edit.Size = new System.Drawing.Size(42, 23);
            this.btn_traer_edit.TabIndex = 18;
            this.btn_traer_edit.Text = "...";
            this.btn_traer_edit.UseVisualStyleBackColor = false;
            this.btn_traer_edit.Click += new System.EventHandler(this.btn_traer_edit_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_agregar.Location = new System.Drawing.Point(78, 264);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(108, 31);
            this.btn_agregar.TabIndex = 20;
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
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(205, 264);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(108, 31);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Location = new System.Drawing.Point(328, 264);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(108, 31);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btncerrar.TabIndex = 23;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dt_libro
            // 
            this.dt_libro.AllowUserToAddRows = false;
            this.dt_libro.AllowUserToDeleteRows = false;
            this.dt_libro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_libro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dt_libro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_libro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dt_libro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_libro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_libro.ColumnHeadersHeight = 30;
            this.dt_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_libro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_libro.EnableHeadersVisualStyles = false;
            this.dt_libro.GridColor = System.Drawing.Color.SteelBlue;
            this.dt_libro.Location = new System.Drawing.Point(495, 83);
            this.dt_libro.Name = "dt_libro";
            this.dt_libro.ReadOnly = true;
            this.dt_libro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_libro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dt_libro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_libro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_libro.Size = new System.Drawing.Size(600, 454);
            this.dt_libro.TabIndex = 24;
            this.dt_libro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_libro_CellContentClick);
            this.dt_libro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_libro_CellContentDoubleClick);
            this.dt_libro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_libro_CellFormatting);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(160, 44);
            this.txtISBN.MaxLength = 50;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(239, 23);
            this.txtISBN.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(112, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "ISBN:";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(160, 175);
            this.txtIdioma.MaxLength = 50;
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(239, 23);
            this.txtIdioma.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(91, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Idioma:";
            // 
            // cbx_estado
            // 
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Disponible",
            "Prestado",
            "Fuera de Uso"});
            this.cbx_estado.Location = new System.Drawing.Point(160, 202);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(239, 24);
            this.cbx_estado.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(92, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(228, 20);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(148, 26);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cboCampos
            // 
            this.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.Items.AddRange(new object[] {
            "nombre",
            "ISBN",
            "Autor",
            "Genero",
            "Editorial",
            "idioma",
            "estado"});
            this.cboCampos.Location = new System.Drawing.Point(101, 20);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(121, 24);
            this.cboCampos.TabIndex = 32;
            // 
            // gbxContenedor
            // 
            this.gbxContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxContenedor.Controls.Add(this.gbxBuscador);
            this.gbxContenedor.Controls.Add(this.gbxCamposs);
            this.gbxContenedor.Controls.Add(this.dt_libro);
            this.gbxContenedor.Location = new System.Drawing.Point(3, 38);
            this.gbxContenedor.Name = "gbxContenedor";
            this.gbxContenedor.Size = new System.Drawing.Size(1101, 608);
            this.gbxContenedor.TabIndex = 35;
            this.gbxContenedor.TabStop = false;
            this.gbxContenedor.Enter += new System.EventHandler(this.gbxContenedor_Enter);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBuscador.Controls.Add(this.cboCampos);
            this.gbxBuscador.Controls.Add(this.txtBuscar);
            this.gbxBuscador.Controls.Add(this.label9);
            this.gbxBuscador.Location = new System.Drawing.Point(570, 19);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(442, 65);
            this.gbxBuscador.TabIndex = 36;
            this.gbxBuscador.TabStop = false;
            // 
            // gbxCamposs
            // 
            this.gbxCamposs.Controls.Add(this.txtISBN);
            this.gbxCamposs.Controls.Add(this.btn_eliminar);
            this.gbxCamposs.Controls.Add(this.btn_traer_gen);
            this.gbxCamposs.Controls.Add(this.btn_traer_edit);
            this.gbxCamposs.Controls.Add(this.btn_traer_autor);
            this.gbxCamposs.Controls.Add(this.txt_id_autor);
            this.gbxCamposs.Controls.Add(this.btn_agregar);
            this.gbxCamposs.Controls.Add(this.label5);
            this.gbxCamposs.Controls.Add(this.txt_nombre_autor);
            this.gbxCamposs.Controls.Add(this.btn_editar);
            this.gbxCamposs.Controls.Add(this.label4);
            this.gbxCamposs.Controls.Add(this.txt_id_genero);
            this.gbxCamposs.Controls.Add(this.label3);
            this.gbxCamposs.Controls.Add(this.label8);
            this.gbxCamposs.Controls.Add(this.label2);
            this.gbxCamposs.Controls.Add(this.txt_genero);
            this.gbxCamposs.Controls.Add(this.label1);
            this.gbxCamposs.Controls.Add(this.cbx_estado);
            this.gbxCamposs.Controls.Add(this.label6);
            this.gbxCamposs.Controls.Add(this.txt_id_editorial);
            this.gbxCamposs.Controls.Add(this.dtp_añop);
            this.gbxCamposs.Controls.Add(this.txtIdioma);
            this.gbxCamposs.Controls.Add(this.txt_nombre);
            this.gbxCamposs.Controls.Add(this.txt_editorial);
            this.gbxCamposs.Controls.Add(this.label7);
            this.gbxCamposs.Location = new System.Drawing.Point(8, 39);
            this.gbxCamposs.Name = "gbxCamposs";
            this.gbxCamposs.Size = new System.Drawing.Size(466, 324);
            this.gbxCamposs.TabIndex = 35;
            this.gbxCamposs.TabStop = false;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1116, 658);
            this.Controls.Add(this.gbxContenedor);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txt_idlibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Libros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_libro)).EndInit();
            this.gbxContenedor.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            this.gbxCamposs.ResumeLayout(false);
            this.gbxCamposs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_id_autor;
        public System.Windows.Forms.TextBox txt_nombre_autor;
        public System.Windows.Forms.TextBox txt_genero;
        public System.Windows.Forms.TextBox txt_id_genero;
        public System.Windows.Forms.TextBox txt_editorial;
        public System.Windows.Forms.TextBox txt_id_editorial;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DateTimePicker dtp_añop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_traer_autor;
        private System.Windows.Forms.Button btn_traer_gen;
        private System.Windows.Forms.Button btn_traer_edit;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.PictureBox btncerrar;
        public System.Windows.Forms.DataGridView dt_libro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboCampos;
        private System.Windows.Forms.GroupBox gbxContenedor;
        public System.Windows.Forms.GroupBox gbxBuscador;
        public System.Windows.Forms.GroupBox gbxCamposs;
        public System.Windows.Forms.TextBox txt_idlibro;
    }
}