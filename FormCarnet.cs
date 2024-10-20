﻿using IntegradorClubDeportivoEquipo4.Entidades;
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
    public partial class FormCarnet : Form {
        public Image? ConvertirAImagen(byte[] dataImagen) {
            if (dataImagen == null || dataImagen.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(dataImagen)) {
                return Image.FromStream(ms);
            }
        }
        public FormCarnet(DataTable dtUsuario) {
            InitializeComponent();
            txtNombreCompleto.Text = $"{dtUsuario.Rows[0]["nombre"].ToString()} {dtUsuario.Rows[0]["apellido"].ToString()}";
            txtNumeroSocio.Text = dtUsuario.Rows[0]["nro_carnet"].ToString();
            txtNumeroDocumento.Text = dtUsuario.Rows[0]["documento"].ToString();
            pbImagenCarnet.Image = ConvertirAImagen((byte[])dtUsuario.Rows[0]["imagen_carnet"]);
        }
    }
}
