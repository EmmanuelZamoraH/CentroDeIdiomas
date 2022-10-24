using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeIdiomas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection coneccion = new SqlConnection("server=DESKTOP-8KPP9F0; database= CentIdiomass; INTEGRATED SECURITY = true");

        public void logear(string usuario, string contrasena)
        {
            try
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario From usuarios" +
                    " WHERE Usuario = @usuario AND Password = @pas", coneccion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Inicio pantalla = new Inicio();
                    pantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña son incorrectos");
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                coneccion.Close();
            }

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Metodo 1
            //coneccion.Open();
            //SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENIA " +
            //    "FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASENIA = @vcontrasenia", coneccion);

            //comando.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
            //comando.Parameters.AddWithValue("@vcontrasenia", txtContrasenia.Text);

            //SqlDataReader lector = comando.ExecuteReader();

            //if (lector.Read())
            //{
            //    coneccion.Close();
            //    Inicio pantalla = new Inicio();
            //    pantalla.Show();
            //    this.Hide();
            //}


            //Metodo 2
            logear(this.txtUsuario.Text, this.txtContrasenia.Text);
        }
    }
}
