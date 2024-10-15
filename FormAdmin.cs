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
    public partial class FormAdmin : Form
    {
        private E_Administrador administrador;
        public FormAdmin(E_Administrador admin)
        {
            InitializeComponent();
            administrador = admin;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            String cadena = $"Nombre: {administrador.Nombre}\nRol: {administrador.Rol}\nTipo Documento: {administrador.TipoDocumento}\n";
            rtxtAdmin.Text = cadena;
        }
    }
}
