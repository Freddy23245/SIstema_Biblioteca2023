namespace Sistemas_Biblioteca
{
    partial class Gestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestiones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsiganrGrupo = new System.Windows.Forms.Button();
            this.cboGrupos = new System.Windows.Forms.ComboBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkModif = new System.Windows.Forms.CheckBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.cboGruposPer = new System.Windows.Forms.ComboBox();
            this.btnAsignarPermisos = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.lblId_grupoPermiso = new System.Windows.Forms.Label();
            this.dt_gruposPermisos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gruposPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAsiganrGrupo);
            this.groupBox1.Controls.Add(this.cboGrupos);
            this.groupBox1.Controls.Add(this.cboUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(750, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuarios a Los Grupos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios:";
            // 
            // btnAsiganrGrupo
            // 
            this.btnAsiganrGrupo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAsiganrGrupo.FlatAppearance.BorderSize = 0;
            this.btnAsiganrGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsiganrGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiganrGrupo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAsiganrGrupo.Location = new System.Drawing.Point(48, 162);
            this.btnAsiganrGrupo.Name = "btnAsiganrGrupo";
            this.btnAsiganrGrupo.Size = new System.Drawing.Size(162, 39);
            this.btnAsiganrGrupo.TabIndex = 2;
            this.btnAsiganrGrupo.Text = "Asignar a Grupo";
            this.btnAsiganrGrupo.UseVisualStyleBackColor = false;
            this.btnAsiganrGrupo.Click += new System.EventHandler(this.btnAsiganrGrupo_Click);
            // 
            // cboGrupos
            // 
            this.cboGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupos.FormattingEnabled = true;
            this.cboGrupos.Location = new System.Drawing.Point(99, 90);
            this.cboGrupos.Name = "cboGrupos";
            this.cboGrupos.Size = new System.Drawing.Size(142, 26);
            this.cboGrupos.TabIndex = 1;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(99, 63);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(142, 26);
            this.cboUsuarios.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitarPermiso);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkLectura);
            this.groupBox2.Controls.Add(this.chkModif);
            this.groupBox2.Controls.Add(this.chkBaja);
            this.groupBox2.Controls.Add(this.chkAlta);
            this.groupBox2.Controls.Add(this.cboPermisos);
            this.groupBox2.Controls.Add(this.cboGruposPer);
            this.groupBox2.Controls.Add(this.btnAsignarPermisos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(108, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignar Permisos a Los Grupos";
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnQuitarPermiso.FlatAppearance.BorderSize = 0;
            this.btnQuitarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuitarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPermiso.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQuitarPermiso.Location = new System.Drawing.Point(258, 212);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(168, 42);
            this.btnQuitarPermiso.TabIndex = 9;
            this.btnQuitarPermiso.Text = "Quitar Permiso";
            this.btnQuitarPermiso.UseVisualStyleBackColor = false;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(24, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Permisos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grupos:";
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.ForeColor = System.Drawing.SystemColors.Window;
            this.chkLectura.Location = new System.Drawing.Point(105, 168);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(82, 22);
            this.chkLectura.TabIndex = 6;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkModif
            // 
            this.chkModif.AutoSize = true;
            this.chkModif.ForeColor = System.Drawing.SystemColors.Window;
            this.chkModif.Location = new System.Drawing.Point(105, 145);
            this.chkModif.Name = "chkModif";
            this.chkModif.Size = new System.Drawing.Size(126, 22);
            this.chkModif.TabIndex = 5;
            this.chkModif.Text = "Modificacion";
            this.chkModif.UseVisualStyleBackColor = true;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.ForeColor = System.Drawing.SystemColors.Window;
            this.chkBaja.Location = new System.Drawing.Point(105, 122);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(60, 22);
            this.chkBaja.TabIndex = 4;
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.ForeColor = System.Drawing.SystemColors.Window;
            this.chkAlta.Location = new System.Drawing.Point(105, 98);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(56, 22);
            this.chkAlta.TabIndex = 3;
            this.chkAlta.Text = "Alta";
            this.chkAlta.UseVisualStyleBackColor = true;
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(105, 60);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(121, 26);
            this.cboPermisos.TabIndex = 2;
            // 
            // cboGruposPer
            // 
            this.cboGruposPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGruposPer.FormattingEnabled = true;
            this.cboGruposPer.Location = new System.Drawing.Point(105, 31);
            this.cboGruposPer.Name = "cboGruposPer";
            this.cboGruposPer.Size = new System.Drawing.Size(121, 26);
            this.cboGruposPer.TabIndex = 1;
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAsignarPermisos.FlatAppearance.BorderSize = 0;
            this.btnAsignarPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsignarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPermisos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAsignarPermisos.Location = new System.Drawing.Point(63, 212);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(168, 42);
            this.btnAsignarPermisos.TabIndex = 0;
            this.btnAsignarPermisos.Text = "Asignar Permisos";
            this.btnAsignarPermisos.UseVisualStyleBackColor = false;
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
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
            this.btncerrar.TabIndex = 19;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblId_grupoPermiso
            // 
            this.lblId_grupoPermiso.AutoSize = true;
            this.lblId_grupoPermiso.Location = new System.Drawing.Point(952, 631);
            this.lblId_grupoPermiso.Name = "lblId_grupoPermiso";
            this.lblId_grupoPermiso.Size = new System.Drawing.Size(86, 13);
            this.lblId_grupoPermiso.TabIndex = 21;
            this.lblId_grupoPermiso.Text = "Id_grupoPermiso";
            this.lblId_grupoPermiso.Visible = false;
            // 
            // dt_gruposPermisos
            // 
            this.dt_gruposPermisos.AllowUserToAddRows = false;
            this.dt_gruposPermisos.AllowUserToDeleteRows = false;
            this.dt_gruposPermisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dt_gruposPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_gruposPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dt_gruposPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_gruposPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_gruposPermisos.ColumnHeadersHeight = 30;
            this.dt_gruposPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_gruposPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_gruposPermisos.EnableHeadersVisualStyles = false;
            this.dt_gruposPermisos.GridColor = System.Drawing.Color.SteelBlue;
            this.dt_gruposPermisos.Location = new System.Drawing.Point(39, 342);
            this.dt_gruposPermisos.Name = "dt_gruposPermisos";
            this.dt_gruposPermisos.ReadOnly = true;
            this.dt_gruposPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_gruposPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dt_gruposPermisos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_gruposPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_gruposPermisos.Size = new System.Drawing.Size(866, 267);
            this.dt_gruposPermisos.TabIndex = 22;
            this.dt_gruposPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gruposPermisos_CellContentClick);
            // 
            // Gestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1116, 658);
            this.Controls.Add(this.dt_gruposPermisos);
            this.Controls.Add(this.lblId_grupoPermiso);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestiones";
            this.Text = "Gestiones";
            this.Load += new System.EventHandler(this.Gestiones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gruposPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsiganrGrupo;
        private System.Windows.Forms.ComboBox cboGrupos;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkModif;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.ComboBox cboGruposPer;
        private System.Windows.Forms.Button btnAsignarPermisos;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.Label lblId_grupoPermiso;
        private System.Windows.Forms.DataGridView dt_gruposPermisos;
    }
}