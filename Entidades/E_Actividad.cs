using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    internal class E_Actividad
    {
        private int idActividad;  
        private String? nombre;
        private int cupo;
        private TimeSpan? horario;
        private double precio;

        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public TimeSpan? Horario { get => horario; set => horario = value; }
        public double Precio { get => precio; set => precio = value; }

        public E_Actividad(int idActividad, string? nombre, int cupo, TimeSpan? horario, double precio)
        {
            IdActividad = idActividad;
            Nombre = nombre;
            Cupo = cupo;
            Horario = horario;
            Precio = precio;
        }
    }
}
