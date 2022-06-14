using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario_1200691.Forms
{
    public partial class FormBase : Form
    {
        public DataSet DataSet = new DataSet();

        public FormBase()
        {
            InitializeComponent();
        }

        // Cerrar formulario
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el formulario", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        // Funcion que ejecuta procedimientos
        public DataSet EjecutarProcedimiento(string comando)
        {
            DataSet ds = new DataSet();

            try
            {
                // Conexión a la base de datos
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GQN6T14\\SQLEXPRESS;Initial Catalog=inventario;Integrated Security=True");
                conn.Open();

                // Ejecutar procedimiento
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando, conn);
                dataAdapter.Fill(ds);

                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al conectarse a la base de datos {ex.Message}.");
            }

            // Retornar procedimiento
            return ds;
        }

        public Boolean TieneDatos(DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0) return true;

            return false;
        }

        public bool ComprobarCodigo(TextBox codigo)
        {
            // Si el campo código está vacío, imprimir mensaje y detener acción
            if (String.IsNullOrEmpty(codigo.Text))
            {
                MessageBox.Show("Campo código vacío.");
                return true;
            }

            return false;
        }

        public virtual void LimpiarInputs()
        {
            MessageBox.Show("Limpiando Inputs");
        }

        public virtual void Consultar()
        {
            MessageBox.Show("Consultando");
        }

        public virtual void Guardar()
        {
            MessageBox.Show("Guardando");
        }

        public virtual void Eliminar()
        {
            MessageBox.Show("Eliminar");
        }
    }
}
