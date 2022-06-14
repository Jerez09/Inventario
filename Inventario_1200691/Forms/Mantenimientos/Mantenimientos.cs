using System;

namespace Inventario_1200691.Forms.Mantenimientos
{
    public partial class Mantenimientos : FormBase
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
