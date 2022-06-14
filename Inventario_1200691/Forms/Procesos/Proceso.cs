using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventario_1200691.Forms
{
    public partial class Proceso : FormBase
    {
        public Proceso()
        {
            InitializeComponent();
        }

        // Funciones
        public void ValidarRegistro(TextBox TextBoxCodigo, TextBox TextBoxNombre, String procedimiento)
        {
            if (String.IsNullOrEmpty(TextBoxCodigo.Text.Trim()))
                return;

            int codigo = int.Parse(TextBoxCodigo.Text.Trim());
            DataSet = EjecutarProcedimiento($"EXEC {procedimiento} {codigo}");

            if (TieneDatos(DataSet))
            {
                TextBoxNombre.Text = DataSet.Tables[0].Rows[0]["nombre"].ToString().Trim();

                if (procedimiento == "Obtener_Producto")
                {
                    TextBoxPrecioProducto.Text = DataSet.Tables[0].Rows[0]["precventa"].ToString().Trim();
                    TextBoxCantidadProducto.Text = "1.00";
                }
            }
            else
            {
                MessageBox.Show("El registro que busca es inválido o no se ha encontrado.");

                TextBoxNombre.Text = "";

                if (procedimiento == "Obtener_Producto")
                {
                    TextBoxPrecioProducto.Text = "";
                    TextBoxCantidadProducto.Text = "1.00";
                }

                TextBoxCodigo.Focus();
            }
        }

        public void SumarImportes()
        {
            double total = DataGridViewProductos.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[4].Value));
            TextBoxTotal.Text = total.ToString("N2");
        }

        public void LimpiarProducto()
        {
            TextBoxProducto.Text = TextBoxNombreProducto.Text = TextBoxCantidadProducto.Text = TextBoxPrecioProducto.Text = "";
            TextBoxProducto.Focus();
        }

        public virtual void LimpiarInputs()
        {
            TextBoxCliente.Text = "";
            TextBoxNombreCliente.Text = "";
            TextBoxProducto.Text = "";
            TextBoxNombreProducto.Text = "";
            TextBoxCantidadProducto.Text = "";
            TextBoxPrecioProducto.Text = "";
            TextBoxTotal.Text = "";
            DataGridViewProductos.Rows.Clear();
        }

        public virtual void Guardar()
        {

        }

        private void Validar_CodigoCliente(object sender, CancelEventArgs e)
        {
            if(LabelCliente.Text.Trim() == "Cliente:") { 
                ValidarRegistro(TextBoxCliente, TextBoxNombreCliente, "Obtener_Cliente");
            } else
            {
                ValidarRegistro(TextBoxCliente, TextBoxNombreCliente, "Obtener_Suplidor");
            }
        }

        private void Validar_CodigoProducto(object sender, CancelEventArgs e)
        {
            ValidarRegistro(TextBoxProducto, TextBoxNombreProducto, "Obtener_Producto");
        }

        // Eventos
        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxProducto.Text.Trim()))
                return;

            string codigo = TextBoxProducto.Text.Trim();
            string nombre = TextBoxNombreProducto.Text.Trim();
            double cantidad= Convert.ToDouble(TextBoxCantidadProducto.Text.Trim());
            double precio = Convert.ToDouble(TextBoxPrecioProducto.Text.Trim());
            double importe  = precio * cantidad;

            DataGridViewProductos.Rows.Add(codigo, nombre, cantidad, precio, importe);
            DataGridViewProductos.Refresh();

            LimpiarProducto();
            SumarImportes();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridViewProductos.Rows.Count <= 0)
                return;

            DataGridViewProductos.Rows.Remove(DataGridViewProductos.CurrentRow);
            SumarImportes();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
