using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Mantenimientos
{
    public partial class MantenimientoProductos : Mantenimientos
    {
        int codigo, cantidad;
        string nombre;
        float precventa, preccompra;
        bool estado;

        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        public override void LimpiarInputs()
        {
            TextBoxCodigo.Text = "";
            TextBoxNombre.Text = "";
            TextBoxPrecioVenta.Text = "";
            TextBoxPrecioCompra.Text = "";
            TextBoxCantidad.Text = "";
            CheckBoxEstado.Checked = false;
        }

        public override void Consultar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Obtener_Producto {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                TextBoxCodigo.Text = DataSet.Tables[0].Rows[0]["codigo"].ToString();
                TextBoxNombre.Text = DataSet.Tables[0].Rows[0]["nombre"].ToString();
                TextBoxPrecioVenta.Text =DataSet.Tables[0].Rows[0]["precventa"].ToString();
                TextBoxPrecioCompra.Text = DataSet.Tables[0].Rows[0]["preccompra"].ToString();
                TextBoxCantidad.Text = DataSet.Tables[0].Rows[0]["cantidad"].ToString();
                estado = bool.Parse(DataSet.Tables[0].Rows[0]["estado"].ToString());
                CheckBoxEstado.Checked = estado;
            } else
            {
                LimpiarInputs();
                MessageBox.Show("Producto no encontrado.");
            }
        }

        public override void Guardar()
        {
            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);
            nombre = TextBoxNombre.Text;
            precventa = float.Parse(TextBoxPrecioVenta.Text);
            preccompra = float.Parse(TextBoxPrecioCompra.Text);
            cantidad = int.Parse(TextBoxCantidad.Text);
            estado = CheckBoxEstado.Checked;

            string comando = $"EXEC Insertar_Producto {codigo}, '{nombre}', '{precventa}', '{preccompra}', {cantidad}, {estado}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Producto guardado correctamente");

            LimpiarInputs();
        }

        public override void Eliminar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Eliminar_Producto {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Producto eliminado correctamente");

            LimpiarInputs();
        }
    }
}
