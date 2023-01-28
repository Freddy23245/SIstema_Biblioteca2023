namespace Sistemas_Biblioteca.Reportes
{
    partial class Reporte_de_Alumnos_Con_Mas_Concurrencia
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AlumnosMasPrestamos1 = new Sistemas_Biblioteca.Reportes.AlumnosMasPrestamos();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.pFecha = new System.Windows.Forms.Panel();
            this.pReporte = new System.Windows.Forms.Panel();
            this.pFecha.SuspendLayout();
            this.pReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.AlumnosMasPrestamos1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1124, 523);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione El Año:";
            // 
            // dtpAño
            // 
            this.dtpAño.CustomFormat = "yyyy";
            this.dtpAño.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño.Location = new System.Drawing.Point(588, 12);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.Size = new System.Drawing.Size(112, 27);
            this.dtpAño.TabIndex = 2;
            this.dtpAño.ValueChanged += new System.EventHandler(this.dtpAño_ValueChanged);
            // 
            // pFecha
            // 
            this.pFecha.Controls.Add(this.dtpAño);
            this.pFecha.Controls.Add(this.label1);
            this.pFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFecha.Location = new System.Drawing.Point(0, 0);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(1124, 56);
            this.pFecha.TabIndex = 3;
            // 
            // pReporte
            // 
            this.pReporte.Controls.Add(this.crystalReportViewer1);
            this.pReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReporte.Location = new System.Drawing.Point(0, 56);
            this.pReporte.Name = "pReporte";
            this.pReporte.Size = new System.Drawing.Size(1124, 523);
            this.pReporte.TabIndex = 4;
            // 
            // Reporte_de_Alumnos_Con_Mas_Concurrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 579);
            this.Controls.Add(this.pReporte);
            this.Controls.Add(this.pFecha);
            this.Name = "Reporte_de_Alumnos_Con_Mas_Concurrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Alumnos Con Mas Concurrencia";
            this.Load += new System.EventHandler(this.Reporte_de_Alumnos_Con_Mas_Concurrencia_Load);
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private AlumnosMasPrestamos AlumnosMasPrestamos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.Panel pFecha;
        private System.Windows.Forms.Panel pReporte;
    }
}