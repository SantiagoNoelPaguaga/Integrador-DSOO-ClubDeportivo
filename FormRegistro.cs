using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorClubDeportivoEquipo4
{
    public partial class FormRegistro : Form
    {
        private Image? imagenAptoFisico;
        private Usuarios usuarios = new Usuarios();
        private bool imagenCarnetCargada = false;
        private Form formAnterior;

        public FormRegistro(Form formAnterior)
        {
            InitializeComponent();

            renderizado(false);

            this.formAnterior = formAnterior;

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
                panelSocio.Visible = true;
                lblSeleccionarPlan.Visible = true;
                cboPlanes.Visible = true;
                lblImagenCarnet.Visible = true;
                pbImagenCarnet.Visible = true;
                btnSubirImagen.Visible = true;
                this.ClientSize = new Size(901, 661);
            }
            else
            {
                panelSocio.Visible = false;
                lblSeleccionarPlan.Visible = false;
                cboPlanes.Visible = false;
                lblImagenCarnet.Visible = false;
                pbImagenCarnet.Visible = false;
                btnSubirImagen.Visible = false;
                this.ClientSize = new Size(585, 661);
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
                MessageBox.Show("Por favor, ingrese su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor, ingrese su apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Por favor, ingrese su dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idTipoDocumento == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("Por favor, ingrese el número de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !esUnEmailValido(email))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                MessageBox.Show("La contraseña no puede estar vacía y debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != repetirPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (imagenAptoFisico == null)
            {
                MessageBox.Show("Por favor, cargue una imagen válida para el Apto Físico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int resultado = usuarios.VerificarExistenciaUsuario(email, documento, idTipoDocumento);

            if (resultado > 0)
            {
                MessageBox.Show("El usuario ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Por favor, cargue una imagen válida para el Carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if ((int)cboPlanes.SelectedValue == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un Plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DataRowView filaSeleccionada = (DataRowView)cboPlanes.SelectedItem;
                        montoMensual = Convert.ToDouble(filaSeleccionada["monto_mensual"]);
                    }

                    E_Usuario usuario = new E_Socio(nombre, apellido, nombreTipoDocumento, documento, telefono, email, password, direccion, rbtSocio.Text, nroCarnet, tieneDeuda, montoMensual, null, pbImagenCarnet.Image, imagenAptoFisico, null);
                    formulario = new FormPago(usuario, this);
                }
                else
                {
                    E_Usuario usuario = new E_NoSocio(nombre, apellido, nombreTipoDocumento, documento, telefono, email, password, direccion, rbtNoSocio.Text, null, imagenAptoFisico);
                    formulario = new FormPago(usuario, this);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close();
        }
    }
}
