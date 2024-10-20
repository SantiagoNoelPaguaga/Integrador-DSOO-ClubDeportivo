using IntegradorClubDeportivoEquipo4.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace IntegradorClubDeportivoEquipo4.Datos
{
    internal class Usuarios
    {
        public DataTable LoginUsuario(string email, string password)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand
                ("Login", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("p_email",
                MySqlDbType.VarChar).Value = email;
                comando.Parameters.Add("p_pass", MySqlDbType.VarChar).Value =
                password;
                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public int VerificarExistenciaUsuario(string email, string documento, int tipoDocumento)
        {
            int resultado;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand
                ("VerificarExistencia", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_email",
                MySqlDbType.VarChar).Value = email;
                comando.Parameters.Add("p_documento", MySqlDbType.VarChar).Value =
                documento;
                comando.Parameters.Add("p_tipo_documento", MySqlDbType.Int32).Value =
                tipoDocumento;

                sqlCon.Open();
                resultado = Convert.ToInt32(comando.ExecuteScalar()); // sabemos que el procedimiento devuelve un count

                return resultado;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public DataTable obtenerTiposDeDocumento()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand
                ("ObtenerTiposDeDocumento", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public DataTable obtenerFormasDePago()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand
                ("ObtenerFormasDePago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public DataTable obtenerActividades()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand
                ("ObtenerActividadesConCuposDisponibles", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public DataTable obtenerPlanes()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand
                ("ObtenerPlanes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public void RealizarTransaccionRegistro(E_Usuario usuario, E_Pago pago)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlTransaction sqlTransaction = null;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                sqlCon.Open();

                sqlTransaction = sqlCon.BeginTransaction();

                if (usuario.Rol != null && usuario.Rol.Equals("Socio", StringComparison.OrdinalIgnoreCase))
                {
                    E_Socio socio = (E_Socio)usuario;
                    int idSocio = RegistrarSocio(socio, sqlTransaction);
                    int idPago = RealizarPago(idSocio, "", pago, sqlTransaction);
                }
                else if (usuario.Rol != null && usuario.Rol.Equals("No Socio", StringComparison.OrdinalIgnoreCase))
                {
                    E_NoSocio nosocio = (E_NoSocio)usuario;
                    int idNoSocio = RegistrarNoSocio(nosocio, sqlTransaction);
                    int idPago = RealizarPago(idNoSocio, "NoSocio", pago, sqlTransaction);
                }

                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        public int RegistrarSocio(E_Socio socio, MySqlTransaction sqlTransaction)
        {
            int idSocio;
            try
            {
                MySqlCommand comando = new MySqlCommand
                ("RegistrarSocio", sqlTransaction.Connection, sqlTransaction);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_nombre",
                MySqlDbType.VarChar).Value = socio.Nombre;

                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value =
                socio.Apellido;

                int idTipoDocumento;
                if (socio.TipoDocumento.Equals("DNI", StringComparison.OrdinalIgnoreCase))
                {
                    idTipoDocumento = 1;
                }
                else if (socio.TipoDocumento.Equals("Pasaporte", StringComparison.OrdinalIgnoreCase))
                {
                    idTipoDocumento = 2;
                }
                else
                {
                    idTipoDocumento = 3;
                }
                comando.Parameters.Add("p_id_tipo_documento", MySqlDbType.Int32).Value = idTipoDocumento;

                comando.Parameters.Add("p_documento",
                MySqlDbType.VarChar).Value = socio.Documento;

                comando.Parameters.Add("p_telefono",
                MySqlDbType.VarChar).Value = socio.Telefono;

                comando.Parameters.Add("p_email",
                MySqlDbType.VarChar).Value = socio.Email;

                comando.Parameters.Add("p_pass",
                MySqlDbType.VarChar).Value = socio.Password;

                comando.Parameters.Add("p_direccion",
                MySqlDbType.VarChar).Value = socio.Direccion;

                comando.Parameters.Add("p_id_rol", MySqlDbType.Int32).Value = 2;

                comando.Parameters.Add("p_nro_carnet",
                MySqlDbType.VarChar).Value = socio.NroCarnet;

                comando.Parameters.Add("p_tiene_deuda",
                MySqlDbType.Byte).Value = socio.TieneDeuda ? (byte)1 : (byte)0;

                socio.calcularFechaVencimiento(DateTime.Now);
                comando.Parameters.Add("p_fecha_vencimiento",
                MySqlDbType.Date).Value = socio.FechaVecimiento;

                byte[] imagenCarnetBytes = ConvertirImagenABytes(socio.ImagenCarnet);
                comando.Parameters.Add("p_imagen_carnet", MySqlDbType.MediumBlob).Value = imagenCarnetBytes;

                byte[] imagenAptoFisicoBytes = ConvertirImagenABytes(socio.ImagenAptoFisico);
                comando.Parameters.Add("p_imagen_apto_fisico", MySqlDbType.MediumBlob).Value = imagenAptoFisicoBytes;

                comando.Parameters.Add("p_id_estado", MySqlDbType.Int32).Value = 2;

                comando.Parameters.Add("p_id_plan", MySqlDbType.Int32).Value = 2;

                MySqlParameter outputParam = new MySqlParameter("p_id_usuario", MySqlDbType.Int32);
                outputParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outputParam);

                idSocio = comando.ExecuteNonQuery();

                return idSocio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int RegistrarNoSocio(E_NoSocio nosocio, MySqlTransaction sqlTransaction)
        {
            int idNoSocio;
            int ultimoIdNoSocio;
            try
            {
                MySqlCommand comando = new MySqlCommand
                ("RegistrarNoSocio", sqlTransaction.Connection, sqlTransaction);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_nombre",
                MySqlDbType.VarChar).Value = nosocio.Nombre;

                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value =
                nosocio.Apellido;

                int idTipoDocumento;
                if (nosocio.TipoDocumento.Equals("DNI", StringComparison.OrdinalIgnoreCase))
                {
                    idTipoDocumento = 1;
                }
                else if (nosocio.TipoDocumento.Equals("Pasaporte", StringComparison.OrdinalIgnoreCase))
                {
                    idTipoDocumento = 2;
                }
                else
                {
                    idTipoDocumento = 3;
                }
                comando.Parameters.Add("p_id_tipo_documento", MySqlDbType.Int32).Value = idTipoDocumento;

                comando.Parameters.Add("p_documento",
                MySqlDbType.VarChar).Value = nosocio.Documento;

                comando.Parameters.Add("p_telefono",
                MySqlDbType.VarChar).Value = nosocio.Telefono;

                comando.Parameters.Add("p_email",
                MySqlDbType.VarChar).Value = nosocio.Email;

                comando.Parameters.Add("p_pass",
                MySqlDbType.VarChar).Value = nosocio.Password;

                comando.Parameters.Add("p_direccion",
                MySqlDbType.VarChar).Value = nosocio.Direccion;

                comando.Parameters.Add("p_id_rol", MySqlDbType.Int32).Value = 3;

                byte[] imagenAptoFisicoBytes = ConvertirImagenABytes(nosocio.ImagenAptoFisico);
                comando.Parameters.Add("p_imagen_apto_fisico", MySqlDbType.MediumBlob).Value = imagenAptoFisicoBytes;

                comando.Parameters.Add("p_id_estado", MySqlDbType.Int32).Value = 2;

                comando.Parameters.Add("p_id_plan", MySqlDbType.Int32).Value = 2;

                MySqlParameter outputParam = new MySqlParameter("p_id_usuario", MySqlDbType.Int32);
                outputParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outputParam);

                idNoSocio = comando.ExecuteNonQuery();
                // no devuelve el id_No Socio en forma correcta por eso lo pido de este forma.
                MySqlCommand commandTwo = new MySqlCommand("SELECT MAX(id_usuario) FROM usuarios", sqlTransaction.Connection, sqlTransaction);
                object result = commandTwo.ExecuteScalar();
                ultimoIdNoSocio = Convert.ToInt32(result);
                MessageBox.Show($"Registrar No Socio: {ultimoIdNoSocio}");

                return ultimoIdNoSocio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int RealizarPago(int idUsuario, string rol, E_Pago pago, MySqlTransaction sqlTransaction)
        {
            int idPago;

            try
            {
                MySqlCommand comando = new MySqlCommand
                ($"RealizarPago{rol}", sqlTransaction.Connection, sqlTransaction);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_id_usuario", MySqlDbType.Int32).Value = idUsuario;

                int idFormaPago;
                if (pago.FormaDePago != null && pago.FormaDePago.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
                {
                    idFormaPago = 2;
                }
                else
                {
                    idFormaPago = 1;
                }
                comando.Parameters.Add("p_id_forma_pago", MySqlDbType.Int32).Value = idFormaPago;

                comando.Parameters.Add("p_fecha_pago",
                MySqlDbType.Date).Value = pago.FechaPago;

                comando.Parameters.Add("p_monto",
                MySqlDbType.Decimal).Value = pago.Monto;

                comando.Parameters.Add("p_cant_cuotas", MySqlDbType.Int32).Value = pago.CantCuotas;

                MySqlParameter outputParam = new MySqlParameter("p_id_pago", MySqlDbType.Int32);
                outputParam.Direction = ParameterDirection.Output;
                comando.Parameters.Add(outputParam);

                comando.Parameters.Add("p_id_actividad", MySqlDbType.Int32).Value = 0;

                // bucle por cada actividad pagada
                foreach (E_Actividad actividad in pago.Actividades)
                {
                    comando.Parameters["p_id_actividad"].Value = actividad.IdActividad;
                    comando.Parameters["p_monto"].Value = actividad.Precio;

                    idPago = comando.ExecuteNonQuery();
                }

                // no devuelve el id_No Socio en forma correcta por eso lo pido de este forma.
                MySqlCommand commandTwo = new MySqlCommand("SELECT MAX(id_pago) FROM pagos", sqlTransaction.Connection, sqlTransaction);
                object result = commandTwo.ExecuteScalar();
                idPago = Convert.ToInt32(result);
                MessageBox.Show("Pago realizado con éxito");

                return idPago;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        // Método auxiliar para convertir las imágenes a arreglo de Bytes para almacenarla en la base de datos
        public byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

    }
}
