using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorClubDeportivoEquipo4.Datos
{
    internal class Prueba
    {
        public DataTable obtenerRoles() {
            MySqlDataReader res;
            DataTable dt = new DataTable();

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand("select * from Roles", sqlCon);

                sqlCon.Open();

                res = comando.ExecuteReader();

                dt.Load(res);

                return dt;
            }
            catch (Exception ex)
            {
                return dt;
                throw;
            }
            finally 
            {
                if (sqlCon.State == ConnectionState.Open) { 
                    sqlCon.Close(); 
                }
            }            
        }

    }
}
