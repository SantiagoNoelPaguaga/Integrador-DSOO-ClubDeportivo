using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Entidades
{
    public class E_Usuario
    {
        private int idUsuario;
        private String? nombre;
        private String? apellido;
        private String? tipoDocumento;
        private String? documento;
        private String? telefono;
        private String? email;
        private String? password;
        private String? direccion;
        private String? rol;

        public E_Usuario(int idUsuario, string? nombre, string? apellido, string? tipoDocumento, string? documento, string? telefono, string? email, string? password, string? direccion, string? rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            Documento = documento;
            Telefono = telefono;
            Email = email;
            Password = password;
            Direccion = direccion;
            Rol = rol;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public string? TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string? Documento { get => documento; set => documento = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public string? Email { get => email; set => email = value; }
        public string? Password { get => password; set => password = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string? Rol { get => rol; set => rol = value; }
    }
}
