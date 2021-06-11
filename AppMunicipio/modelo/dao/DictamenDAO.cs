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
    public class DictamenDAO
    {
        public static void registrarDicatmen(Dictamen dictamen)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    String fecha = dictamen.FechaHora.ToString("yyyy-MM-dd");
                    String hora = dictamen.FechaHora.ToString("HH:mm:ss");
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Dictamen " +
                        "(descripcion, fechaHora, idReporte, idUsuario) " +
                        "VALUES('{0}', '{1}', {2}, {3});",
                        dictamen.Descripcion, fecha + " " + hora, dictamen.IdReporte, dictamen.IdUsuario);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DictamenDAO registrarDicatmen(Dictamen dictamen):");
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
        }

        public static Dictamen getDictamen(Reporte reporte)
        {
            Dictamen dictamen = new Dictamen();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT d.folio, d.descripcion, d.fechaHora, d.idReporte, d.idUsuario, " +
                        "u.nombre, u.apellidoPaterno, u.apellidoMaterno " +
                         "FROM SistemaVehicular.dbo.Dictamen d " +
                         "INNER JOIN SistemaVehicular.dbo.Usuario u " +
                         "ON d.idUsuario = u.idUsuario " +
                         "WHERE d.idReporte = {0}; ", reporte.IdReporte);

                    command = new SqlCommand(query, conn);

                    Console.WriteLine(query);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dictamen.Folio = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        dictamen.Descripcion = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        dictamen.FechaHora = (!dataReader.IsDBNull(2)) ? dataReader.GetDateTime(2) : new DateTime();
                        dictamen.IdReporte = (!dataReader.IsDBNull(3)) ? dataReader.GetInt32(3) : 0;
                        dictamen.IdUsuario = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;

                        String nombre = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        String apellidoPaterno = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        String apellidoMaterno = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";

                        dictamen.NombrePerito = nombre + " " + apellidoPaterno + " " + apellidoMaterno;

                    }

                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DictamenDAO getDictamen(Reporte reporte):");
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

            return dictamen;
        }

    }
}
