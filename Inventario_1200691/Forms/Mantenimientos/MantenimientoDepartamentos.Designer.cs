namespace Inventario_1200691.Forms.Mantenimientos
{
    partial class MantenimientoDepartamentos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitutloClientes = new System.Windows.Forms.Label();
            this.CheckBoxEstado = new System.Windows.Forms.CheckBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextBoxCodigo = new System.Windows.Forms.TextBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TitutloClientes);
            this.panel2.Controls.Add(this.CheckBoxEstado);
            this.panel2.Controls.Add(this.TextBoxNombre);
            this.panel2.Controls.Add(this.LabelNombre);
            this.panel2.Controls.Add(this.TextBoxCodigo);
            this.panel2.Controls.Add(this.LabelCodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // TitutloClientes
            // 
            this.TitutloClientes.AutoSize = true;
            this.TitutloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitutloClientes.Location = new System.Drawing.Point(54, 66);
            this.TitutloClientes.Name = "TitutloClientes";
            this.TitutloClientes.Size = new System.Drawing.Size(256, 20);
            this.TitutloClientes.TabIndex = 13;
            this.TitutloClientes.Text = "Mantenimiento Departamentos";
            // 
            // CheckBoxEstado
            // 
            this.CheckBoxEstado.AutoSize = true;
            this.CheckBoxEstado.Location = new System.Drawing.Point(54, 235);
            this.CheckBoxEstado.Name = "CheckBoxEstado";
            this.CheckBoxEstado.Size = new System.Drawing.Size(59, 17);
            this.CheckBoxEstado.TabIndex = 12;
            this.CheckBoxEstado.Text = "Estado";
            this.CheckBoxEstado.UseVisualStyleBackColor = true;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(54, 197);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(288, 20);
            this.TextBoxNombre.TabIndex = 10;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(51, 181);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 6;
            this.LabelNombre.Text = "Nombre";
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.Location = new System.Drawing.Point(54, 147);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCodigo.TabIndex = 11;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Location = new System.Drawing.Point(51, 131);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(40, 13);
            this.LabelCodigo.TabIndex = 7;
            this.LabelCodigo.Text = "Código";
            // 
            // MantenimientoDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "MantenimientoDepartamentos";
            this.ShowIcon = false;
            this.Text = "Mantenimiento Departamentos";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitutloClientes;
        private System.Windows.Forms.CheckBox CheckBoxEstado;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextBoxCodigo;
        private System.Windows.Forms.Label LabelCodigo;
    }
}