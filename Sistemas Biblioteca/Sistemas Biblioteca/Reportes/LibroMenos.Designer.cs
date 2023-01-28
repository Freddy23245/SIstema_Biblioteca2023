namespace Sistemas_Biblioteca.Reportes
{
    partial class LibroMenos
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
            this.LibrosMenos1 = new Sistemas_Biblioteca.Reportes.LibrosMenos();
            this.dtp_año = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pAño = new System.Windows.Forms.Panel();
            this.pReportes = new System.Windows.Forms.Panel();
            this.pAño.SuspendLayout();
            this.pReportes.SuspendLayout();
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
            this.crystalReportViewer1.ReportSource = this.LibrosMenos1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1077, 478);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_año
            // 
            this.dtp_año.CustomFormat = "yyyy";
            this.dtp_año.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_año.Location = new System.Drawing.Point(574, 12);
            this.dtp_año.Name = "dtp_año";
            this.dtp_año.Size = new System.Drawing.Size(131, 31);
            this.dtp_año.TabIndex = 4;
            this.dtp_año.ValueChanged += new System.EventHandler(this.dtp_año_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el año:";
            // 
            // pAño
            // 
            this.pAño.Controls.Add(this.dtp_año);
            this.pAño.Controls.Add(this.label1);
            this.pAño.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAño.Location = new System.Drawing.Point(0, 0);
            this.pAño.Name = "pAño";
            this.pAño.Size = new System.Drawing.Size(1077, 63);
            this.pAño.TabIndex = 5;
            // 
            // pReportes
            // 
            this.pReportes.Controls.Add(this.crystalReportViewer1);
            this.pReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReportes.Location = new System.Drawing.Point(0, 63);
            this.pReportes.Name = "pReportes";
            this.pReportes.Size = new System.Drawing.Size(1077, 478);
            this.pReportes.TabIndex = 6;
            // 
            // LibroMenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 541);
            this.Controls.Add(this.pReportes);
            this.Controls.Add(this.pAño);
            this.Name = "LibroMenos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibroMenos";
            this.Load += new System.EventHandler(this.LibroMenos_Load);
            this.pAño.ResumeLayout(false);
            this.pAño.PerformLayout();
            this.pReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dtp_año;
        private System.Windows.Forms.Label label1;
        private LibrosMenos LibrosMenos1;
        private System.Windows.Forms.Panel pAño;
        private System.Windows.Forms.Panel pReportes;
    }
}