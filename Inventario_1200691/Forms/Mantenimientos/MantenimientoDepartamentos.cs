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
    public partial class MantenimientoDepartamentos : Mantenimientos
    {
        int codigo;
        string nombre, email, direccion;
        bool estado;

        public MantenimientoDepartamentos()
        {
            InitializeComponent();
        }

        public override void LimpiarInputs()
        {
            TextBoxCodigo.Text = "";
            TextBoxNombre.Text = "";
            CheckBoxEstado.Checked = false;
        }

        public override void Consultar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Obtener_Departamento {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                TextBoxCodigo.Text = DataSet.Tables[0].Rows[0]["codigo"].ToString();
                TextBoxNombre.Text = DataSet.Tables[0].Rows[0]["nombre"].ToString();
                estado = bool.Parse(DataSet.Tables[0].Rows[0]["estado"].ToString());
                CheckBoxEstado.Checked = estado;
            } else
            {
                LimpiarInputs();
                MessageBox.Show("Departamento no encontrado.");
            }
        }

        public override void Guardar()
        {
            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);
            nombre = TextBoxNombre.Text;
            estado = CheckBoxEstado.Checked;

            string comando = $"EXEC Insertar_Departamento {codigo}, '{nombre}', {estado}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Departamento guardado correctamente");

            LimpiarInputs();
        }

        public override void Eliminar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Eliminar_Departamento {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Departamento eliminado correctamente");

            LimpiarInputs();
        }
    }
}
