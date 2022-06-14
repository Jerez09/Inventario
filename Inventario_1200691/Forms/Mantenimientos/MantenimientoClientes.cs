using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Mantenimientos
{
    public partial class MantenimientoClientes : Mantenimientos
    {
        int codigo;
        string nombre, email, direccion;
        bool estado;

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        public override void LimpiarInputs()
        {
            TextBoxCodigo.Text = "";
            TextBoxNombre.Text = "";
            TextBoxEmail.Text = "";
            TextBoxDireccion.Text = "";
            CheckBoxEstado.Checked = false;
        }

        public override void Consultar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Obtener_Cliente {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                TextBoxCodigo.Text = DataSet.Tables[0].Rows[0]["codigo"].ToString();
                TextBoxNombre.Text = DataSet.Tables[0].Rows[0]["nombre"].ToString();
                TextBoxEmail.Text = DataSet.Tables[0].Rows[0]["email"].ToString();
                TextBoxDireccion.Text = DataSet.Tables[0].Rows[0]["direccion"].ToString();
                estado = bool.Parse(DataSet.Tables[0].Rows[0]["estado"].ToString());
                CheckBoxEstado.Checked = estado;
            } else
            {
                LimpiarInputs();
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        public override void Guardar()
        {
            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);
            nombre = TextBoxNombre.Text;
            email = TextBoxEmail.Text;
            direccion = TextBoxDireccion.Text;
            estado = CheckBoxEstado.Checked;

            string comando = $"EXEC Insertar_Cliente {codigo}, '{nombre}', '{email}', '{direccion}', {estado}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Cliente guardado correctamente");

            LimpiarInputs();
        }

        public override void Eliminar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Eliminar_Cliente {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Cliente eliminado correctamente");

            LimpiarInputs();
        }
    }
}
