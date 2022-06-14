namespace Inventario_1200691.Forms.Mantenimientos
{
    partial class MantenimientoUsuarios
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
            this.TitutloClientes = new System.Windows.Forms.Label();
            this.CheckBoxEstado = new System.Windows.Forms.CheckBox();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextBoxCodigo = new System.Windows.Forms.TextBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.TextBoxNivel = new System.Windows.Forms.NumericUpDown();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.PanelMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Location = new System.Drawing.Point(0, 222);
            // 
            // PanelMantenimiento
            // 
            this.PanelMantenimiento.Controls.Add(this.TextBoxUsuario);
            this.PanelMantenimiento.Controls.Add(this.LabelUsuario);
            this.PanelMantenimiento.Controls.Add(this.TextBoxNivel);
            this.PanelMantenimiento.Controls.Add(this.TitutloClientes);
            this.PanelMantenimiento.Controls.Add(this.CheckBoxEstado);
            this.PanelMantenimiento.Controls.Add(this.LabelDireccion);
            this.PanelMantenimiento.Controls.Add(this.TextBoxPassword);
            this.PanelMantenimiento.Controls.Add(this.LabelPassword);
            this.PanelMantenimiento.Controls.Add(this.TextBoxNombre);
            this.PanelMantenimiento.Controls.Add(this.LabelNombre);
            this.PanelMantenimiento.Controls.Add(this.TextBoxCodigo);
            this.PanelMantenimiento.Controls.Add(this.LabelCodigo);
            this.PanelMantenimiento.Size = new System.Drawing.Size(691, 450);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(691, 0);
            this.panel1.Size = new System.Drawing.Size(109, 450);
            // 
            // TitutloClientes
            // 
            this.TitutloClientes.AutoSize = true;
            this.TitutloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitutloClientes.Location = new System.Drawing.Point(51, 80);
            this.TitutloClientes.Name = "TitutloClientes";
            this.TitutloClientes.Size = new System.Drawing.Size(203, 20);
            this.TitutloClientes.TabIndex = 23;
            this.TitutloClientes.Text = "Mantenimiento Usuarios";
            // 
            // CheckBoxEstado
            // 
            this.CheckBoxEstado.AutoSize = true;
            this.CheckBoxEstado.Location = new System.Drawing.Point(51, 396);
            this.CheckBoxEstado.Name = "CheckBoxEstado";
            this.CheckBoxEstado.Size = new System.Drawing.Size(59, 17);
            this.CheckBoxEstado.TabIndex = 22;
            this.CheckBoxEstado.Text = "Estado";
            this.CheckBoxEstado.UseVisualStyleBackColor = true;
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Location = new System.Drawing.Point(48, 335);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(31, 13);
            this.LabelDireccion.TabIndex = 14;
            this.LabelDireccion.Text = "Nivel";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(51, 300);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(288, 20);
            this.TextBoxPassword.TabIndex = 19;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(48, 284);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(51, 246);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(288, 20);
            this.TextBoxNombre.TabIndex = 20;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(48, 230);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 16;
            this.LabelNombre.Text = "Nombre";
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.Location = new System.Drawing.Point(51, 148);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCodigo.TabIndex = 21;
            this.TextBoxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.Validar_CodigoUsuario);
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Location = new System.Drawing.Point(48, 132);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(40, 13);
            this.LabelCodigo.TabIndex = 17;
            this.LabelCodigo.Text = "Código";
            // 
            // TextBoxNivel
            // 
            this.TextBoxNivel.Location = new System.Drawing.Point(51, 353);
            this.TextBoxNivel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TextBoxNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextBoxNivel.Name = "TextBoxNivel";
            this.TextBoxNivel.Size = new System.Drawing.Size(120, 20);
            this.TextBoxNivel.TabIndex = 24;
            this.TextBoxNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Location = new System.Drawing.Point(51, 196);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUsuario.TabIndex = 26;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(48, 180);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(43, 13);
            this.LabelUsuario.TabIndex = 25;
            this.LabelUsuario.Text = "Usuario";
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MantenimientoUsuarios";
            this.Text = "Matenimiento Usuarios";
            this.PanelMantenimiento.ResumeLayout(false);
            this.PanelMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxNivel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitutloClientes;
        private System.Windows.Forms.CheckBox CheckBoxEstado;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextBoxCodigo;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.NumericUpDown TextBoxNivel;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Label LabelUsuario;
    }
}