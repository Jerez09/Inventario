namespace Inventario_1200691.Forms
{
    partial class Proceso
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
            this.LabelCliente = new System.Windows.Forms.LinkLabel();
            this.TextBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.TextBoxCliente = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonAnadir = new System.Windows.Forms.Button();
            this.LabelProducto = new System.Windows.Forms.LinkLabel();
            this.TextBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.TextBoxPrecioProducto = new System.Windows.Forms.TextBox();
            this.TextBoxCantidadProducto = new System.Windows.Forms.TextBox();
            this.TextBoxProducto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.LinkLabel();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotonGuardar);
            this.panel1.Controls.Add(this.BotonEliminar);
            this.panel1.Location = new System.Drawing.Point(688, 77);
            this.panel1.Size = new System.Drawing.Size(112, 373);
            this.panel1.Controls.SetChildIndex(this.BotonEliminar, 0);
            this.panel1.Controls.SetChildIndex(this.BotonGuardar, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelCliente);
            this.panel2.Controls.Add(this.TextBoxNombreCliente);
            this.panel2.Controls.Add(this.TextBoxCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 1;
            // 
            // LabelCliente
            // 
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCliente.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LabelCliente.LinkColor = System.Drawing.Color.Black;
            this.LabelCliente.Location = new System.Drawing.Point(12, 10);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(51, 16);
            this.LabelCliente.TabIndex = 2;
            this.LabelCliente.TabStop = true;
            this.LabelCliente.Text = "Cliente:";
            // 
            // TextBoxNombreCliente
            // 
            this.TextBoxNombreCliente.Location = new System.Drawing.Point(142, 9);
            this.TextBoxNombreCliente.Name = "TextBoxNombreCliente";
            this.TextBoxNombreCliente.Size = new System.Drawing.Size(521, 20);
            this.TextBoxNombreCliente.TabIndex = 1;
            // 
            // TextBoxCliente
            // 
            this.TextBoxCliente.Location = new System.Drawing.Point(69, 10);
            this.TextBoxCliente.Name = "TextBoxCliente";
            this.TextBoxCliente.Size = new System.Drawing.Size(67, 20);
            this.TextBoxCliente.TabIndex = 1;
            this.TextBoxCliente.Validating += new System.ComponentModel.CancelEventHandler(this.Validar_CodigoCliente);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BotonAnadir);
            this.panel3.Controls.Add(this.LabelProducto);
            this.panel3.Controls.Add(this.TextBoxNombreProducto);
            this.panel3.Controls.Add(this.TextBoxPrecioProducto);
            this.panel3.Controls.Add(this.TextBoxCantidadProducto);
            this.panel3.Controls.Add(this.TextBoxProducto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 39);
            this.panel3.TabIndex = 2;
            // 
            // BotonAnadir
            // 
            this.BotonAnadir.Location = new System.Drawing.Point(596, 9);
            this.BotonAnadir.Name = "BotonAnadir";
            this.BotonAnadir.Size = new System.Drawing.Size(67, 23);
            this.BotonAnadir.TabIndex = 3;
            this.BotonAnadir.Text = "Añadir";
            this.BotonAnadir.UseVisualStyleBackColor = true;
            this.BotonAnadir.Click += new System.EventHandler(this.BotonAnadir_Click);
            // 
            // LabelProducto
            // 
            this.LabelProducto.AutoSize = true;
            this.LabelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProducto.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LabelProducto.LinkColor = System.Drawing.Color.Black;
            this.LabelProducto.Location = new System.Drawing.Point(12, 12);
            this.LabelProducto.Name = "LabelProducto";
            this.LabelProducto.Size = new System.Drawing.Size(64, 16);
            this.LabelProducto.TabIndex = 2;
            this.LabelProducto.TabStop = true;
            this.LabelProducto.Text = "Producto:";
            // 
            // TextBoxNombreProducto
            // 
            this.TextBoxNombreProducto.Location = new System.Drawing.Point(159, 10);
            this.TextBoxNombreProducto.Name = "TextBoxNombreProducto";
            this.TextBoxNombreProducto.Size = new System.Drawing.Size(302, 20);
            this.TextBoxNombreProducto.TabIndex = 1;
            // 
            // TextBoxPrecioProducto
            // 
            this.TextBoxPrecioProducto.Location = new System.Drawing.Point(529, 10);
            this.TextBoxPrecioProducto.Name = "TextBoxPrecioProducto";
            this.TextBoxPrecioProducto.Size = new System.Drawing.Size(59, 20);
            this.TextBoxPrecioProducto.TabIndex = 1;
            // 
            // TextBoxCantidadProducto
            // 
            this.TextBoxCantidadProducto.Location = new System.Drawing.Point(469, 10);
            this.TextBoxCantidadProducto.Name = "TextBoxCantidadProducto";
            this.TextBoxCantidadProducto.Size = new System.Drawing.Size(52, 20);
            this.TextBoxCantidadProducto.TabIndex = 1;
            // 
            // TextBoxProducto
            // 
            this.TextBoxProducto.Location = new System.Drawing.Point(84, 10);
            this.TextBoxProducto.Name = "TextBoxProducto";
            this.TextBoxProducto.Size = new System.Drawing.Size(67, 20);
            this.TextBoxProducto.TabIndex = 1;
            this.TextBoxProducto.Validating += new System.ComponentModel.CancelEventHandler(this.Validar_CodigoProducto);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LabelTotal);
            this.panel4.Controls.Add(this.TextBoxTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(688, 39);
            this.panel4.TabIndex = 3;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LabelTotal.LinkColor = System.Drawing.Color.Black;
            this.LabelTotal.Location = new System.Drawing.Point(547, 12);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(41, 16);
            this.LabelTotal.TabIndex = 2;
            this.LabelTotal.TabStop = true;
            this.LabelTotal.Text = "Total:";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Location = new System.Drawing.Point(596, 10);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(86, 20);
            this.TextBoxTotal.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DataGridViewProductos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(688, 334);
            this.panel5.TabIndex = 4;
            // 
            // DataGridViewProductos
            // 
            this.DataGridViewProductos.AllowUserToAddRows = false;
            this.DataGridViewProductos.AllowUserToDeleteRows = false;
            this.DataGridViewProductos.AllowUserToResizeColumns = false;
            this.DataGridViewProductos.AllowUserToResizeRows = false;
            this.DataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio,
            this.importe});
            this.DataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProductos.Name = "DataGridViewProductos";
            this.DataGridViewProductos.RowHeadersWidth = 85;
            this.DataGridViewProductos.Size = new System.Drawing.Size(688, 334);
            this.DataGridViewProductos.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 11.35239F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 449.2386F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 325;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 13.13634F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.FillWeight = 13.13634F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 60;
            // 
            // importe
            // 
            this.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importe.FillWeight = 13.13634F;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonEliminar.Location = new System.Drawing.Point(0, 271);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(112, 51);
            this.BotonEliminar.TabIndex = 1;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonGuardar.Location = new System.Drawing.Point(0, 220);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(112, 51);
            this.BotonGuardar.TabIndex = 2;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Proceso";
            this.Text = "Formulario Procesos";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel LabelProducto;
        private System.Windows.Forms.Button BotonAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.LinkLabel LabelTotal;
        public System.Windows.Forms.LinkLabel LabelCliente;
        public System.Windows.Forms.DataGridView DataGridViewProductos;
        public System.Windows.Forms.TextBox TextBoxNombreCliente;
        public System.Windows.Forms.TextBox TextBoxCliente;
        public System.Windows.Forms.TextBox TextBoxProducto;
        public System.Windows.Forms.TextBox TextBoxNombreProducto;
        public System.Windows.Forms.TextBox TextBoxPrecioProducto;
        public System.Windows.Forms.TextBox TextBoxCantidadProducto;
        public System.Windows.Forms.TextBox TextBoxTotal;
        public System.Windows.Forms.Panel panel5;
    }
}