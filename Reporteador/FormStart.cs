using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reporteador
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            /*
             * Al hacer click en el botón Connectar intentará conectarse con MySQL
             */

            // obtenemos el valor de los textbox
            string server = textBoxServer.Text;
            string user = textBoxUser.Text;
            string password = textBoxPassword.Text;

            // cadena que incluye los datos de la conección
            string connectionString = String.Format("Server={0};Uid={1};Password={2};", server, user, password);

            // conección
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            // testing conección
            command.CommandText = "SHOW DATABASES;";
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(String.Format("{0}", reader.GetValue(0).ToString()), "xd");
                }
            }
            catch (Exception ex)
            {
                // si entramos aquí significa que la conección falló
                MessageBox.Show(
                    String.Format(
                        "No se pudo conectar al servidor \"{0}\" con el usuario \"{1}\"\n\n{2}",
                        server,
                        user,
                        ex.Message
                    ),
                    "Conección fallida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
