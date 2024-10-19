using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    public class E_NoSocio : E_Usuario
    {
        private List<E_Pago> pagos = new List<E_Pago>();
        private String? estadoAptoFisico;
        private Image? imagenAptoFisico;


        public E_NoSocio(string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol, string? estadoAptoFisico, Image imagenAptoFisico)
        : base(nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {
            EstadoAptoFisico = estadoAptoFisico;
            ImagenAptoFisico = imagenAptoFisico;
        }

        public E_NoSocio(int idUsuario, string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol, string? estadoAptoFisico, Image imagenAptoFisico)
        : base(idUsuario, nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {
            EstadoAptoFisico = estadoAptoFisico;
            ImagenAptoFisico = imagenAptoFisico;
        }

        public string? EstadoAptoFisico { get => estadoAptoFisico; set => estadoAptoFisico = value; }
        public Image? ImagenAptoFisico { get => imagenAptoFisico; set => imagenAptoFisico = value; }
        internal List<E_Pago> Pagos { get => pagos; set => pagos = value; }
    }
}
