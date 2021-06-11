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
    class ReporteDAO
    {
        public static void registrarReporte(Reporte reporte)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {

                    String fecha = reporte.FechaHora.ToString("yyyy-MM-dd");
                    
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Reporte " +
                        "(direccionSiniestro, estatus, fechaHora, idDelegacion) " +
                        "VALUES ('{0}', '{1}', '{2}', {3});",
                        reporte.DireccionSiniestro, reporte.Estatus,
                        fecha, reporte.IdDelegacion);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción ReporteDAO registrarReporte(Reporte reporte):");
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


        public static Reporte getUltimoReporte()
        {
            Reporte reporte = new Reporte();

            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;

                    String query = "SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                                    "FROM SistemaVehicular.dbo.Reporte r " +
                                    "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                                    "ON r.idDelegacion = d.idDelegacion " +
                                    "WHERE idReporte = (SELECT MAX(idReporte) FROM SistemaVehicular.dbo.Reporte);";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción ReporteDAO getUltimoReporte():");
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
            return reporte;
        }

    }
}
