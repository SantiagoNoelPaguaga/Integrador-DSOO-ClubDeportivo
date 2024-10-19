using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    public class E_Administrador : E_Usuario
    {
        public E_Administrador(string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol) : 
               base(nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {

        }

        public E_Administrador(int idUsuario, string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol) :
               base(idUsuario, nombre, apellido, tipoDocumento, documento, telefono, email, password, direccion, rol)
        {

        }
    }
}
