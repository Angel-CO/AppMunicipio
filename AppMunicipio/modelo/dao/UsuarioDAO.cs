using AppMunicipio.modelo.db;
using AppMunicipio.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMunicipio.modelo.dao
{
    class UsuarioDAO
    {
        public static Usuario getUsuario(String nombreUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT u.idUsuario, u.nombreUsuario, " +
                        "u.contrasenia, u.nombre, u.apellidoPaterno, " +
                        "u.apellidoMaterno, u.cargo, u.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Usuario u INNER JOIN " +
                        "SistemaVehicular.dbo.Delegacion d " +
                        "ON u.idDelegacion = d.idDelegacion " +
                        "WHERE u.nombreUsuario = '{0}';", nombreUsuario);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.NombreUsuario = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contrasenia = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Nombre = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.ApellidoPaterno = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        usuario.ApellidoMaterno = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(7)) ? dataReader.GetInt32(7) : 0;
                        usuario.Delegacion = (!dataReader.IsDBNull(8)) ? dataReader.GetString(8) : "";
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarionDAO getUsuario(String nombreUsuario, String contrasenia):");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return usuario;
        }
    }
}
