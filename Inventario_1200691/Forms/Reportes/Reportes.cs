using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_1200691.Forms.Reportes
{
    public partial class Reportes : FormBase
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BotonImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public virtual void Buscar()
        {
            MessageBox.Show("Buscando");
        }

        public virtual void Imprimir()
        {
            MessageBox.Show("Imprimiendo");
        }

    }
}
