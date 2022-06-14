using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_1200691.Models
{
    internal class UsuarioView
    {
        public int codigo { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public int nivel { get; set; }
        public bool estado { get; set; }
    }
}
