namespace Inventario_1200691.Forms
{
    partial class FormBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.BotonCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(688, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 450);
            this.panel1.TabIndex = 0;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonCerrar.Location = new System.Drawing.Point(0, 399);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(112, 51);
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormBase";
            this.Text = "Formulario Base";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonCerrar;
        public System.Windows.Forms.Panel panel1;
    }
}