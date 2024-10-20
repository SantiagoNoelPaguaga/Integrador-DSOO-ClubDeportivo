
using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System.Data;

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
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !esUnEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.");
                return;
            }

            Usuarios login = new Usuarios();
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormRegistro();
            this.Hide();
            formulario.Show();
        }

        private bool esUnEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
