using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Mantenimientos
{
    public partial class MantenimientoUsuarios : Mantenimientos
    {
        int codigo, nivel;
        string usuario, nombre, password;
        bool estado;

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        // Limpiar TextBoxes
        public override void LimpiarInputs()
        {
            TextBoxCodigo.Text = "";
            TextBoxUsuario.Text = "";
            TextBoxNombre.Text = "";
            TextBoxPassword.Text = "";
            TextBoxNivel.Value = 1;
            CheckBoxEstado.Checked = false;
        }

        public override void Guardar()
        {
            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text.Trim());
            usuario = TextBoxUsuario.Text.Trim();
            nombre = TextBoxNombre.Text.Trim();
            password = Classes.Seguridad.Encriptar(TextBoxPassword.Text);
            nivel = (int)TextBoxNivel.Value;
            estado = CheckBoxEstado.Checked;

            string comando = $"EXEC Insertar_Usuario {codigo}, '{usuario}', '{nombre}', '{password}', {nivel}, {estado}";
            DataSet = EjecutarProcedimiento(comando);

            MessageBox.Show("Usuario guardado correctamente");

            LimpiarInputs();
        }

        private void Validar_CodigoUsuario(object sender, CancelEventArgs e)
        {
            if (ComprobarCodigo(TextBoxCodigo))
                return;

            codigo = int.Parse(TextBoxCodigo.Text);

            string comando = $"EXEC Obtener_Usuario {codigo}";
            DataSet = EjecutarProcedimiento(comando);

            if (TieneDatos(DataSet))
            {
                TextBoxCodigo.Text = DataSet.Tables[0].Rows[0]["codigo"].ToString();
                TextBoxUsuario.Text = DataSet.Tables[0].Rows[0]["username"].ToString();
                TextBoxNombre.Text = DataSet.Tables[0].Rows[0]["nombre"].ToString();
                TextBoxPassword.Text = Classes.Seguridad.Desencriptar(DataSet.Tables[0].Rows[0]["password"].ToString());
                TextBoxNivel.Value = int.Parse(DataSet.Tables[0].Rows[0]["nivel"].ToString());
                estado = bool.Parse(DataSet.Tables[0].Rows[0]["estado"].ToString());
                CheckBoxEstado.Checked = estado;
            }
            else
            {
                TextBoxUsuario.Text = "";
                TextBoxNombre.Text = "";
                TextBoxPassword.Text = "";
                TextBoxNivel.Value = 1;
                CheckBoxEstado.Checked = false;
            }
        }
    }
}
