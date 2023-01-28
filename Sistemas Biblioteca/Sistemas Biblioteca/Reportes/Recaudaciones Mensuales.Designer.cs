namespace Sistemas_Biblioteca.Reportes
{
    partial class Recaudaciones_Mensuales
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_año = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Recaudaciones1011 = new Sistemas_Biblioteca.Reportes.Recaudaciones101();
            this.pFecha = new System.Windows.Forms.Panel();
            this.pReporte = new System.Windows.Forms.Panel();
            this.pFecha.SuspendLayout();
            this.pReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el año:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtp_año
            // 
            this.dtp_año.CustomFormat = "yyyy";
            this.dtp_año.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_año.Location = new System.Drawing.Point(633, 5);
            this.dtp_año.Name = "dtp_año";
            this.dtp_año.Size = new System.Drawing.Size(131, 31);
            this.dtp_año.TabIndex = 2;
            this.dtp_año.ValueChanged += new System.EventHandler(this.dtp_año_ValueChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Recaudaciones1011;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1218, 616);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pFecha
            // 
            this.pFecha.Controls.Add(this.dtp_año);
            this.pFecha.Controls.Add(this.label1);
            this.pFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFecha.Location = new System.Drawing.Point(0, 0);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(1218, 47);
            this.pFecha.TabIndex = 4;
            // 
            // pReporte
            // 
            this.pReporte.Controls.Add(this.crystalReportViewer1);
            this.pReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReporte.Location = new System.Drawing.Point(0, 47);
            this.pReporte.Name = "pReporte";
            this.pReporte.Size = new System.Drawing.Size(1218, 616);
            this.pReporte.TabIndex = 5;
            // 
            // Recaudaciones_Mensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 663);
            this.Controls.Add(this.pReporte);
            this.Controls.Add(this.pFecha);
            this.Name = "Recaudaciones_Mensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudaciones_Mensuales";
            this.Load += new System.EventHandler(this.Recaudaciones_Mensuales_Load);
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_año;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Recaudaciones101 Recaudaciones1011;
        private System.Windows.Forms.Panel pFecha;
        private System.Windows.Forms.Panel pReporte;
    }
}