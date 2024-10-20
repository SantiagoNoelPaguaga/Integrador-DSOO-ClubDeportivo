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

namespace IntegradorClubDeportivoEquipo4 {
    public partial class FormSocio : Form {
        private E_Socio socio;
        private Usuarios usuarios = new Usuarios();
        public FormSocio(E_Socio socioObj) {
            InitializeComponent();
            socio = socioObj;
        }

        private void FormSocio_Load(object sender, EventArgs e) {
            lblDatosUsuario.Text = $"Usuario: {socio.Apellido}, {socio.Nombre} ({socio.Rol})";
        }

        private void btnCarnet_Click(object sender, EventArgs e) {
            DataTable carnet = usuarios.EmitirCarnet(socio.IdUsuario);
            this.Hide();
            Form formulario = new FormCarnet(carnet);
            formulario.Show();
        }
    }
}
