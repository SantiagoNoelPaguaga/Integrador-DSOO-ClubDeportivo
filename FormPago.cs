using IntegradorClubDeportivoEquipo4.Datos;
using IntegradorClubDeportivoEquipo4.Entidades;
using System.Data;

namespace IntegradorClubDeportivoEquipo4
{
    public partial class FormPago : Form
    {
        private E_Usuario usuario;
        private Usuarios usuarios = new Usuarios();

        public FormPago(E_Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

        }

        private void FormPago_Load(object sender, EventArgs e)
        {
            DataTable dtCantCuotas = new DataTable();
            dtCantCuotas.Columns.Add("Id", typeof(int));
            dtCantCuotas.Columns.Add("Nombre", typeof(string));

            dtCantCuotas.Rows.Add(-1, "Seleccionar");
            dtCantCuotas.Rows.Add(1, "1 Cuota");
            dtCantCuotas.Rows.Add(2, "3 Cuotas");
            dtCantCuotas.Rows.Add(3, "6 Cuotas");

            cboCantidadCuotas.DataSource = dtCantCuotas;
            cboCantidadCuotas.DisplayMember = "Nombre";
            cboCantidadCuotas.ValueMember = "Id";

            if (usuario.Rol != null && usuario.Rol.Equals("No Socio", StringComparison.OrdinalIgnoreCase))
            {
                DataTable dtActividades = usuarios.obtenerActividades();

                dgvActividades.DataSource = dtActividades;

                dgvActividades.Columns[0].Visible = false;

                dgvActividades.Columns[1].HeaderText = "Nombre";
                dgvActividades.Columns[2].HeaderText = "Cupo";
                dgvActividades.Columns[3].HeaderText = "Horario";
                dgvActividades.Columns[4].HeaderText = "Precio";

                foreach (DataGridViewColumn column in dgvActividades.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                dgvActividades.SelectionChanged += dgvActividades_SelectionChanged;
            }
            else
            {
                ClientSize = new Size(735, 400);

                panelActividades.Visible = false;

                panelPago.Location = new Point(39, 34);

                E_Socio socio = (E_Socio)usuario;

                txtMonto.Text = socio.MontoMensual.ToString();
            }

        }

        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            renderizado(false);
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            renderizado(true);
        }

        private void renderizado(bool mostrarCuotas)
        {

            if (mostrarCuotas)
            {
                btnPagar.Location = new Point(273, 245);

                lblCantCuotas.Visible = true;

                cboCantidadCuotas.Visible = true;
            }
            else
            {
                btnPagar.Location = new Point(273, 201);

                lblCantCuotas.Visible = false;

                cboCantidadCuotas.Visible = false;
            }
        }

        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            decimal monto = 0;
            int idActividad = 0;

            if (dgvActividades.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvActividades.SelectedRows)
                {
                    if (row.Cells["precio"].Value != DBNull.Value)
                    {
                        decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                        monto += precio;

                        int actividad = Convert.ToInt16(row.Cells["id_actividad"].Value);

                        idActividad += actividad;
                    }
                }
                txtMonto.Text = $"{monto}";
            }
            else
            {
                txtMonto.Text = "0";
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            String? formaDePago;
            int cantCuotas;
            if (rbtEfectivo.Checked)
            {
                formaDePago = rbtEfectivo.Text;
            }
            else
            {
                formaDePago = rbtTarjeta.Text;
            }

            if (formaDePago.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
            {
                cantCuotas = 1;
            }
            else
            {
                if ((int)cboCantidadCuotas.SelectedValue == -1)
                {
                    MessageBox.Show("Por favor, ingrese la cantidad de cuotas.");
                    return;
                }
                else if ((int)cboCantidadCuotas.SelectedValue == 1)
                {
                    cantCuotas = 1;
                }
                else if ((int)cboCantidadCuotas.SelectedValue == 2)
                {
                    cantCuotas = 3;
                }
                else
                {
                    cantCuotas = 6;
                }
            }

            if (usuario.Rol != null && usuario.Rol.Equals("No Socio", StringComparison.OrdinalIgnoreCase))
            {
                double monto;

                if (dgvActividades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione al menos una actividad.");
                    return;
                }
                else
                {
                    monto = Convert.ToDouble(txtMonto.Text);
                }

                List<E_Actividad> actividadesSeleccionadas = new List<E_Actividad>();

                foreach (DataGridViewRow fila in dgvActividades.SelectedRows)
                {
                    E_Actividad actividad = new E_Actividad
                    (
                        Convert.ToInt32(fila.Cells["id_actividad"].Value),
                        fila.Cells["nombre_actividad"].Value.ToString(),
                        Convert.ToInt32(fila.Cells["cupo"].Value),
                        TimeSpan.Parse(fila.Cells["horario"].Value.ToString()),
                        Convert.ToDouble(fila.Cells["precio"].Value)
                    );

                    actividadesSeleccionadas.Add(actividad);
                }

                E_Pago pago = new E_Pago(monto, formaDePago, cantCuotas, actividadesSeleccionadas);
                usuarios.RealizarTransaccionRegistro(usuario, pago);
            }
            else
            {
                double monto = Convert.ToDouble(txtMonto.Text);

                E_Pago pago = new E_Pago(monto, formaDePago, cantCuotas, null);

                usuarios.RealizarTransaccionRegistro(usuario, pago);
            }
        }
    }
}
