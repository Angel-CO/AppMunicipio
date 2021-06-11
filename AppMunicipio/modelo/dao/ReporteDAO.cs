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

        public static List<Reporte> getAllReportes()
        {
            List<Reporte> reportes = new List<Reporte>();
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
                        "ON r.idDelegacion = d.idDelegacion;";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getAllReportes():");
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
            return reportes;
        }


        public static List<Reporte> getReportesPorDelegacion(Delegacion delegacion)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE d.idDelegacion = {0};", delegacion.IdDelegacion);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    Console.WriteLine(query);
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorDelegacion(Delegacion delegacion):");
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
            return reportes;
        }

        public static List<Reporte> getReportesPorFecha(DateTime fecha)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String fechaString = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE r.fechaHora = '{0}';", fechaString);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorFecha(DateTime fecha):");
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
            return reportes;
        }

        public static List<Reporte> getReportesPorEstatus(String estatus)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE r.estatus = '{0}';", estatus);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    Console.WriteLine(query);
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorEstatus(String estatus):");
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
            return reportes;
        }

        public static List<Reporte> getReportesPorEstatusYFecha(String estatus, DateTime fecha)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String fechaString = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE r.fechaHora = '{0}' AND r.estatus = '{1}';", fechaString, estatus);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorEstatusYFecha(String estatus, DateTime fecha):");
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
            return reportes;
        }

        public static List<Reporte> getReportesPorFechaYDelegacion(DateTime fecha, Delegacion delegacion)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String fechaString = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE r.fechaHora = '{0}' AND r.idDelegacion = '{1}';", fechaString, delegacion.IdDelegacion);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorEstatusYFecha(String estatus, DateTime fecha):");
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
            return reportes;
        }

        public static List<Reporte> getReportesPorEstatusFechaYDelegacion(String estatus, DateTime fecha, Delegacion delegacion)
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String fechaString = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    String query = String.Format("SELECT r.idReporte, r.direccionSiniestro, r.estatus, r.fechaHora, r.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Reporte r " +
                        "INNER JOIN SistemaVehicular.dbo.Delegacion d " +
                        "ON r.idDelegacion = d.idDelegacion " +
                        "WHERE r.estatus = '{0}' AND r.fechaHora = '{1}' AND r.idDelegacion = '{2}';", estatus, fechaString, delegacion.IdDelegacion);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();

                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.DireccionSiniestro = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        reporte.Estatus = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.FechaHora = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        reporte.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        reporte.NombreDelegacion = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";

                        reportes.Add(reporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Reporte DAO getReportesPorEstatusFechaYDelegacion(String estatus, DateTime fecha, Delegacion delegacion):");
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
            return reportes;
        }

        public static void cambiarEsatusReporte(Reporte reporte)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("UPDATE SistemaVehicular.dbo.Reporte " +
                        "SET estatus = 'Dictaminado' " +
                        "WHERE idReporte = {0};", reporte.IdReporte);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción ReporteDAO cambiarEsatusReporte(Reporte reporte):");
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
