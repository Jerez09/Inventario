using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Mantenimientos
{
    public partial class MantenimientoSuplidores : Mantenimientos
    {
        int codigo;
        string nombre, email, direccion;
        bool estado;

        public MantenimientoSuplidores()
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

            string comando = $"EXEC Obtener_Suplidor {codigo}";
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
                MessageBox.Show("Suplidor no encontrado.");
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

            string comando = $"EXEC Insertar_Suplidor {codigo}, '{nombre}', '{email}', '{direccion}', {estado}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Suplidor guardado correctamente");

            LimpiarInputs();
        }

        public override void Eliminar()
        {

            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Eliminar_Suplidor {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Suplidor eliminado correctamente");

            LimpiarInputs();
        }
    }
}
