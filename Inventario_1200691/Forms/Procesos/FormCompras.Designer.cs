namespace Inventario_1200691.Forms.Procesos
{
    partial class FormCompras
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
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCliente
            // 
            this.LabelCliente.Location = new System.Drawing.Point(12, 11);
            this.LabelCliente.Size = new System.Drawing.Size(60, 16);
            this.LabelCliente.Text = "Suplidor:";
            // 
            // TextBoxNombreCliente
            // 
            this.TextBoxNombreCliente.Location = new System.Drawing.Point(159, 9);
            this.TextBoxNombreCliente.Size = new System.Drawing.Size(504, 20);
            // 
            // TextBoxCliente
            // 
            this.TextBoxCliente.Location = new System.Drawing.Point(82, 9);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormCompras";
            this.Text = "Compras";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}