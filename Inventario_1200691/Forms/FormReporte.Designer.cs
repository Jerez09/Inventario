namespace Inventario_1200691.Forms
{
    partial class FormReporte
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
            this.ReportViewerMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewerMain
            // 
            this.ReportViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewerMain.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerMain.Name = "ReportViewerMain";
            this.ReportViewerMain.ServerReport.BearerToken = null;
            this.ReportViewerMain.Size = new System.Drawing.Size(800, 450);
            this.ReportViewerMain.TabIndex = 0;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportViewerMain);
            this.Name = "FormReporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerMain;
    }
}