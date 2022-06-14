using System;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Procesos
{
    public partial class FormCompras : Proceso
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            if (DataGridViewProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardadr");
                return;
            }

            string numero_factura = "";
            string fecha = "";
            string codigo_cliente = TextBoxCliente.Text.Trim();
            string nombre_sup = TextBoxNombreCliente.Text.Trim();
            bool estado = false;

            string comando = $"EXEC Actualizar_Compras '{numero_factura}', '{fecha}', '{codigo_cliente}', '{estado}'";

            DataSet dataSet = EjecutarProcedimiento(comando);

            if (!TieneDatos(dataSet))
            {
                MessageBox.Show("Error al registrar la factura");
                return;
            }

            numero_factura = dataSet.Tables[0].Rows[0]["numfac"].ToString().Trim();

            foreach (DataGridViewRow row in DataGridViewProductos.Rows)
            {
                string codigo_prod = row.Cells[0].Value.ToString();
                string nombre_prod = row.Cells[1].Value.ToString();
                double cantidad_vendida = Convert.ToDouble(row.Cells[2].Value);
                double precio = Convert.ToDouble(row.Cells[3].Value);
                double importe = Convert.ToDouble(row.Cells[4].Value);

                comando = $"EXEC Actualizar_DetallesCompras {numero_factura}, {codigo_prod}, '{nombre_prod}', {cantidad_vendida}, {precio}, {importe}";

                dataSet = EjecutarProcedimiento(comando);

                if (!TieneDatos(dataSet))
                {
                    MessageBox.Show("Error al registrar los detalles de la factura");
                    return;
                }
            }

            dataSet = EjecutarProcedimiento($"EXEC Obtener_Compras {numero_factura}");

            if (!TieneDatos(dataSet))
            {
                MessageBox.Show("La factura no tiene datos");
                return;
            }

            MessageBox.Show("Productos agregados al inventario correctamente");
            // Imprimir reporte

            LimpiarInputs();
        }
    }
}
