using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System.Data;

namespace IntegradorClubDeportivoEquipo4
{
    public partial class FormRegistro : Form
    {
        //private Byte[]? imagenCarnetBytes;
        //private Byte[]? imagenAptoFisicoBytes;
        private Image? imagenAptoFisico;
        private Usuarios usuarios = new Usuarios();
        private bool imagenCarnetCargada = false;

        public FormRegistro()
        {
            InitializeComponent();

            renderizado(false);

            imagenAptoFisico = null;

            Rectangle res = Screen.PrimaryScreen.Bounds;

            this.Location = new Point((res.Width - this.Size.Width) / 2, 60);

            DataTable tiposDocumento = usuarios.obtenerTiposDeDocumento();

            DataRow filaSeleccionar1 = tiposDocumento.NewRow();

            filaSeleccionar1["id_tipo_documento"] = -1;
            filaSeleccionar1["nombre_tipo_documento"] = "Seleccionar";

            tiposDocumento.Rows.InsertAt(filaSeleccionar1, 0);

            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "nombre_tipo_documento";
            cboTipoDocumento.ValueMember = "id_tipo_documento";

            DataTable dtPlanes = usuarios.obtenerPlanes();

            dtPlanes.Columns.Add("descripcion_precio", typeof(string));

            foreach (DataRow row in dtPlanes.Rows)
            {
                row["descripcion_precio"] = row["descripcion"] + " - $" + Convert.ToDecimal(row["monto_mensual"]).ToString("F2");
            }

            DataRow filaSeleccionar2 = dtPlanes.NewRow();
            filaSeleccionar2["id_plan"] = -1;
            filaSeleccionar2["descripcion_precio"] = "Seleccionar";

            dtPlanes.Rows.InsertAt(filaSeleccionar2, 0);

            cboPlanes.DataSource = dtPlanes;
            cboPlanes.DisplayMember = "descripcion_precio";
            cboPlanes.ValueMember = "id_plan";

        }

        private void btnAgregarAptoFisico_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblNombreArchivo.Text = Path.GetFileName(openFileDialog.FileName);

                lblNombreArchivo.Visible = true;

                imagenAptoFisico = Image.FromFile(openFileDialog.FileName);

                //imagenAptoFisico = new Bitmap(openFileDialog.FileName);

                //imagenAptoFisicoBytes = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImagenCarnet.Image = Image.FromFile(openFileDialog.FileName);

                imagenCarnetCargada = true;

                //pbImagenCarnet.Image = new Bitmap(openFileDialog.FileName);

                //imagenCarnetBytes = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void rbtSocio_CheckedChanged(object sender, EventArgs e)
        {
            renderizado(true);
        }

        private void rbtNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            renderizado(false);
        }

        private void renderizado(bool esSocio)
        {

            if (esSocio)
            {
                btnContinuar.Location = new Point(175, 812);

                panelSocio.Visible = true;
            }
            else
            {
                btnContinuar.Location = new Point(175, 600);

                panelSocio.Visible = false;

                ClientSize = new Size(509, 400);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            String? nombre = txtNombre.Text;
            String? apellido = txtApellido.Text;
            String? telefono = txtTelefono.Text;
            String? direccion = txtDireccion.Text;
            int idTipoDocumento = (int)cboTipoDocumento.SelectedValue;
            String? nombreTipoDocumento = cboTipoDocumento.Text;
            String? documento = txtDocumento.Text;
            String? email = txtEmail.Text;
            String? password = txtPassword.Text;
            String? repetirPassword = txtRepetirPassword.Text;
            bool esSocio = rbtSocio.Checked;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese su nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor, ingrese su apellido.");
                return;
            }


            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Por favor, ingrese su dirección.");
                return;
            }

            if (idTipoDocumento == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("Por favor, ingrese el número de documento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !esUnEmailValido(email))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                MessageBox.Show("La contraseña no puede estar vacía y debe tener al menos 8 caracteres.");
                return;
            }

            if (password != repetirPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (imagenAptoFisico == null)
            {
                MessageBox.Show("Por favor, cargue una imagen válida para el Apto Físico.");
                return;
            }

            int resultado = usuarios.VerificarExistenciaUsuario(email, documento, idTipoDocumento);

            if (resultado > 0)
            {
                MessageBox.Show("El usuario ingresado ya existe");
                return;
            }
            else
            {
                Form formulario;
                if (esSocio)
                {
                    String? nroCarnet = generarCarnet();
                    bool tieneDeuda = false;
                    double montoMensual;

                    if (pbImagenCarnet.Image == null || !imagenCarnetCargada)
                    {
                        MessageBox.Show("Por favor, cargue una imagen válida para el Carnet.");
                        return;
                    }

                    if ((int)cboPlanes.SelectedValue == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un Plan.");
                        return;
                    }
                    else
                    {
                        DataRowView filaSeleccionada = (DataRowView)cboPlanes.SelectedItem;
                        montoMensual = Convert.ToDouble(filaSeleccionada["monto_mensual"]);
                    }

                    E_Usuario usuario = new E_Socio(nombre, apellido, nombreTipoDocumento, documento, telefono, email, password, direccion, rbtSocio.Text, nroCarnet, tieneDeuda, montoMensual, null, pbImagenCarnet.Image, imagenAptoFisico, null);
                    formulario = new FormPago(usuario);
                }
                else
                {
                    E_Usuario usuario = new E_NoSocio(nombre, apellido, nombreTipoDocumento, documento, telefono, email, password, direccion, rbtNoSocio.Text, null, imagenAptoFisico);
                    formulario = new FormPago(usuario);
                }

                this.Hide();
                formulario.Show();

            }
        }

        private String generarCarnet()
        {
            Random rnd = new Random();

            String num = rnd.Next(10000000, 99999999).ToString();

            num = num + "-" + (char)rnd.Next('A', 'Z' + 1);

            return num;
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
