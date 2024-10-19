using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    public class E_Socio : E_Usuario
    {
        private String? nroCarnet;
        private List<E_Pago> pagos = new List<E_Pago>();
        private bool tieneDeuda;
        private double montoMensual;
        private DateTime? fechaVecimiento;
        private Image? imagenCarnet;
        private Image? imagenAptoFisico;
        private String? estadoAptoFisico;

        public E_Socio(string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol, string? nroCarnet, bool tieneDeuda, double montoMensual, DateTime? fechaVecimiento, Image? imagenCarnet, Image? imagenAptoFisico, string? estadoAptoFisico)
        : base(nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {
            NroCarnet = nroCarnet;
            TieneDeuda = tieneDeuda;
            MontoMensual = montoMensual;
            FechaVecimiento = fechaVecimiento;
            ImagenCarnet = imagenCarnet;
            ImagenAptoFisico = imagenAptoFisico;
            EstadoAptoFisico = estadoAptoFisico;
        }

        public E_Socio(int idUsuario, string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol, string? nroCarnet, bool tieneDeuda, double montoMensual, DateTime? fechaVecimiento, Image? imagenCarnet, Image? imagenAptoFisico, string? estadoAptoFisico)
        : base(idUsuario, nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {
            NroCarnet = nroCarnet;
            TieneDeuda = tieneDeuda;
            MontoMensual = montoMensual;
            FechaVecimiento = fechaVecimiento;
            ImagenCarnet = imagenCarnet;
            ImagenAptoFisico = imagenAptoFisico;
            EstadoAptoFisico = estadoAptoFisico;
        }

        public string? NroCarnet { get => nroCarnet; set => nroCarnet = value; }
        public bool TieneDeuda { get => tieneDeuda; set => tieneDeuda = value; }
        public double MontoMensual { get => montoMensual; set => montoMensual = value; }
        public DateTime? FechaVecimiento { get => fechaVecimiento; set => fechaVecimiento = value; }
        public Image? ImagenCarnet { get => imagenCarnet; set => imagenCarnet = value; }
        public Image? ImagenAptoFisico { get => imagenAptoFisico; set => imagenAptoFisico = value; }
        public string? EstadoAptoFisico { get => estadoAptoFisico; set => estadoAptoFisico = value; }
        internal List<E_Pago> Pagos { get => pagos; set => pagos = value; }

        public void calcularFechaVencimiento(DateTime fecha) {
            FechaVecimiento = fecha.AddDays(30);
        }
    }
}
