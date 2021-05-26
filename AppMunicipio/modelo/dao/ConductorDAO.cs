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
    class ConductorDAO
    {
        public static List<Conductor> getAllConductores()
        {
            List<Conductor> conductores = new List<Conductor>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT c.idConductor, c.nombre, " +
                        "c.apellidoPaterno, c.apellidoMaterno, " +
                        "c.fechaNacimiento, c.numLicencia, c.telefono " +
                        "FROM SistemaVehicular.dbo.Conductor c;";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Conductor conductor = new Conductor();

                        conductor.IdConductor = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductor.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        conductor.ApellidoPaterno = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        conductor.ApellidoMaterno = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        conductor.FechaNacimiento = (!dataReader.IsDBNull(4)) ? dataReader.GetDateTime(4) : new DateTime();
                        conductor.NumLicencia = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        conductor.Telefono = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";

                        conductores.Add(conductor);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Concdutor DAO getAllConductores():");
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
            return conductores;
        }
        public static void agregarConductor(Conductor conductor)
        {
            SqlConnection conn = null;
            try
            {
                string fechaNacimiento = conductor.FechaNacimiento.Year +
                    "-" + conductor.FechaNacimiento.Month +
                    "-" + conductor.FechaNacimiento.Day;

                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Conductor " +
                        "(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, numLicencia, telefono)" +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                        conductor.Nombre, conductor.ApellidoPaterno, conductor.ApellidoMaterno,
                        fechaNacimiento, conductor.NumLicencia, conductor.Telefono

                        );
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Concdutor DAO agregarConductor(Conductor conductor):");
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

        public static void modificarConductor(Conductor conductor)
        {
            SqlConnection conn = null;
            try
            {
                string fechaNacimiento = conductor.FechaNacimiento.Year +
                    "-" + conductor.FechaNacimiento.Month +
                    "-" + conductor.FechaNacimiento.Day;

                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("UPDATE SistemaVehicular.dbo.Conductor " +
                        "SET nombre = '{0}', apellidoPaterno = '{1}', apellidoMaterno = '{2}', " +
                        "fechaNacimiento = '{3}', numLicencia = '{4}', telefono = '{5}'" +
                        "WHERE idConductor = {6}",
                        conductor.Nombre, conductor.ApellidoPaterno, conductor.ApellidoMaterno,
                        fechaNacimiento, conductor.NumLicencia, conductor.Telefono,
                        conductor.IdConductor);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();

                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Concdutor DAO modificarConductor(Conductor conductor):");
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

        public static void eliminarConductor(Conductor conductor)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("DELETE FROM SistemaVehicular.dbo.Conductor " +
                        "WHERE idConductor = {0}", conductor.IdConductor);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();

                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Concdutor DAO eliminarConductor(Conductor conductor):");
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
    }
}
