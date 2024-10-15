
using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System.Data;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IntegradorClubDeportivoEquipo4
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DataTable datosUsuario = login.LoginUsuario(txtEmail.Text, txtPassword.Text);

            if (datosUsuario.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");

                String? rol = datosUsuario.Rows[0]["nombre_rol"].ToString();
                
                Form formulario;

                if (rol != null && rol.Equals("Administrador"))
                {
                    E_Administrador admin = new E_Administrador
                    (
                        Convert.ToInt32(datosUsuario.Rows[0]["id_usuario"]), 
                        datosUsuario.Rows[0]["nombre"].ToString(), 
                        datosUsuario.Rows[0]["apellido"].ToString(), 
                        datosUsuario.Rows[0]["nombre_tipo_documento"].ToString(), 
                        datosUsuario.Rows[0]["documento"].ToString(), 
                        datosUsuario.Rows[0]["telefono"].ToString(), 
                        datosUsuario.Rows[0]["email"].ToString(), 
                        null,
                        datosUsuario.Rows[0]["direccion"].ToString(), 
                        datosUsuario.Rows[0]["nombre_rol"].ToString()
                    );
                    formulario = new FormAdmin(admin);

                }
                else if (rol != null && rol.Equals("Socio"))
                {
                    E_Administrador admin = new E_Administrador
                   (
                       Convert.ToInt32(datosUsuario.Rows[0]["id_usuario"]),
                       datosUsuario.Rows[0]["nombre"].ToString(),
                       datosUsuario.Rows[0]["apellido"].ToString(),
                       datosUsuario.Rows[0]["nombre_tipo_documento"].ToString(),
                       datosUsuario.Rows[0]["documento"].ToString(),
                       datosUsuario.Rows[0]["telefono"].ToString(),
                       datosUsuario.Rows[0]["email"].ToString(),
                       null,
                       datosUsuario.Rows[0]["direccion"].ToString(),
                       datosUsuario.Rows[0]["nombre_rol"].ToString()
                   );
              
                    formulario = new FormAdmin(admin);
                }
                else
                {
                    E_Administrador admin = new E_Administrador
                   (
                       Convert.ToInt32(datosUsuario.Rows[0]["id_usuario"]),
                       datosUsuario.Rows[0]["nombre"].ToString(),
                       datosUsuario.Rows[0]["apellido"].ToString(),
                       datosUsuario.Rows[0]["nombre_tipo_documento"].ToString(),
                       datosUsuario.Rows[0]["documento"].ToString(),
                       datosUsuario.Rows[0]["telefono"].ToString(),
                       datosUsuario.Rows[0]["email"].ToString(),
                       null,
                       datosUsuario.Rows[0]["direccion"].ToString(),
                       datosUsuario.Rows[0]["nombre_rol"].ToString()
                   );

                    formulario = new FormAdmin(admin);
                }

                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intente nuevamente!");
            }
        }

       
    }
}
