using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_1200691.Forms
{
    public partial class Login : Form
    {
        string username, password;
        string url = "https://localhost:7278/api/usuarios";
        List<Models.UsuarioView> usuarios;

        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            string res = await GetHTTP();
            usuarios = JsonConvert.DeserializeObject<List<Models.UsuarioView>>(res);
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            // Validación de los campos vacíos
            if (TextBoxUsuario.Text.Trim() == "" || TextBoxPassword.Text.Trim() == "") {
                MessageBox.Show("El campo usuario o contraseña está vacío.");
                return;
            }

            username = TextBoxUsuario.Text.Trim();
            password = TextBoxPassword.Text.Trim();

            foreach (var usuario in usuarios)
            {
                if (usuario.username == username)
                {
                    if (Classes.Seguridad.Desencriptar(usuario.password) == password)
                    {
                        MessageBox.Show("Sesión iniciada correctamente.");

                        MenuPrincipal obj = new MenuPrincipal();
                        this.Hide();
                        obj.Show();

                        return;
                    }

                    MessageBox.Show("Contraseña Incorrecta.");
                    return ;
                }
            }

            MessageBox.Show("No se ha encontrado el usuario");
        }

        public async Task<string> GetHTTP()
        {
            // Hacer request y obtener respuesta
            WebRequest req = WebRequest.Create(url);
            WebResponse res = req.GetResponse();

            // Crea
            StreamReader streamReader = new StreamReader(res.GetResponseStream());

            return await streamReader.ReadToEndAsync();
        }
    }
}
