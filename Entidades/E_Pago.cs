using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    internal class E_Pago
    {
        private int idPago;
        private DateTime fechaPago;
        private double monto;
        private String? formaDePago;
        private int cantCuotas;
        private List<E_Actividad> actividades = new List<E_Actividad>();

        public int IdPago { get => idPago; set => idPago = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public double Monto { get => monto; set => monto = value; }
        public string? FormaDePago { get => formaDePago; set => formaDePago = value; }
        public int CantCuotas { get => cantCuotas; set => cantCuotas = value; }
        internal List<E_Actividad> Actividades { get => actividades; set => actividades = value; }

        public E_Pago(int idPago, DateTime fechaPago, double monto, string? formaDePago, int cantCuotas, List<E_Actividad> actividades)
        {
            IdPago = idPago;
            FechaPago = fechaPago;
            Monto = monto;
            FormaDePago = formaDePago;
            CantCuotas = cantCuotas;
            Actividades = actividades;
        }

        public E_Pago(double monto, string? formaDePago, int cantCuotas, List<E_Actividad> actividades)
        {
            FechaPago = DateTime.Now;
            Monto = monto;
            FormaDePago = formaDePago;
            CantCuotas = cantCuotas;
            Actividades = actividades;
        }
    }
}
