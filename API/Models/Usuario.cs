using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Usuario
    {
        [Key]
        public int codigo { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public int nivel { get; set; }
        public bool estado { get; set; }
    }
}
