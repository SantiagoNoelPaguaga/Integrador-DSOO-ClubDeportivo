
using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System.Data;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IntegradorClubDeportivoEquipo4
{
    public partial class FormLogin : Form
    {
        public Image? ConvertirAImagen(byte[] dataImagen) {
            if (dataImagen == null || dataImagen.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(dataImagen)) {
                return Image.FromStream(ms);
            }
        }
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
                    E_Socio socio = new E_Socio
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
                        datosUsuario.Rows[0]["nombre_rol"].ToString(),
                        datosUsuario.Rows[0]["nro_carnet"].ToString(),
                        (bool)datosUsuario.Rows[0]["tiene_deuda"],
                        Convert.ToDouble(datosUsuario.Rows[0]["monto_mensual"]),
                        Convert.ToDateTime(datosUsuario.Rows[0]["fecha_vencimiento"]),
                        ConvertirAImagen((byte[])datosUsuario.Rows[0]["imagen_carnet"]),
                        ConvertirAImagen((byte[])datosUsuario.Rows[0]["imagen_apto_fisico"]),
                        datosUsuario.Rows[0]["nombre_estado"].ToString()
                    );
                    
                    formulario = new FormSocio(socio);
                }
                else
                {
                    E_NoSocio noSocio = new E_NoSocio
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
                        datosUsuario.Rows[0]["nombre_rol"].ToString(),
                        datosUsuario.Rows[0]["nombre_estado"].ToString(),
                        ConvertirAImagen((byte[])datosUsuario.Rows[0]["imagen_apto_fisico"])
                   );

                    formulario = new FormNoSocio(noSocio);
                }

                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intente nuevamente!");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
