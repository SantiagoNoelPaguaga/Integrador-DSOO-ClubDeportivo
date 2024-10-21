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

namespace IntegradorClubDeportivoEquipo4 {
    public partial class FormNoSocio : Form
    {
        private E_NoSocio noSocio;

        public FormNoSocio(E_NoSocio noSocioObj)
        {
            InitializeComponent();
            noSocio = noSocioObj;
        }

        private void FormNoSocio_Load(object sender, EventArgs e)
        {
            lblDatosUsuario.Text = $"Usuario: {noSocio.Apellido}, {noSocio.Nombre} ({noSocio.Rol})";
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPago(noSocio, this);
            this.Hide();
            formulario.Show();
        }
    }
}
