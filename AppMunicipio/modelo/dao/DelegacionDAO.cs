using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AppMunicipio.modelo.db;
using AppMunicipio.modelo.poco;


namespace AppMunicipio.modelo.dao
{
    public class DelegacionDAO
    {
        public static List<Delegacion> getAllDelegaciones()
        {
            List<Delegacion> delegaciones = new List<Delegacion>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT d.idDelegacion, d.nombre, d.calle, d.numero, d.colonia, d.codigoPostal, d.telefono, d.correo, d.tipoDelegacion, d.idMunicipio, m.nombre " +
                        "FROM SistemaVehicular.dbo.Delegacion d " +
                        "INNER JOIN SistemaVehicular.dbo.Municipio m " +
                        "ON d.idMunicipio = m.idMunicipio;";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Delegacion delegacion = new Delegacion();

                        delegacion.IdDelegacion = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        delegacion.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        delegacion.Calle = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        delegacion.Numero = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        delegacion.Colonia = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        delegacion.CodigoPostal = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        delegacion.Telefono = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        delegacion.Correo = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        delegacion.TipoDelegacion = (!dataReader.IsDBNull(8)) ? dataReader.GetString(8) : "";
                        delegacion.IdMunicipio = (!dataReader.IsDBNull(9)) ? dataReader.GetInt32(9) : 0;
                        delegacion.NombreMunicipio = (!dataReader.IsDBNull(10)) ? dataReader.GetString(10) : "";

                        delegaciones.Add(delegacion);
                    }
                    Console.WriteLine(query);
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DelegacionDAO getAllDelegaciones():");
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
            return delegaciones;
        }

        public static void registrarDelegacion(Delegacion delegacion)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Delegacion " +
                        "(nombre, calle, numero, colonia, codigoPostal, telefono, correo, tipoDelegacion, idMunicipio) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8});",
                        delegacion.Nombre, delegacion.Calle, delegacion.Numero, delegacion.Colonia,
                        delegacion.CodigoPostal, delegacion.Telefono, delegacion.Correo, delegacion.TipoDelegacion, delegacion.IdMunicipio);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DelegacionDAO registrarDelegacion(Delegacion delegacion):");
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

        public static void modificarDelegacion(Delegacion delegacion)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("UPDATE SistemaVehicular.dbo.Delegacion " +
                        "SET nombre = '{0}', calle = '{1}', numero = '{2}', " +
                        "colonia = '{3}', codigoPostal = '{4}', telefono = '{5}', " +
                        "correo = '{6}', tipoDelegacion = '{7}', idMunicipio = {8} " +
                        "WHERE idDelegacion = {9};",
                        delegacion.Nombre, delegacion.Calle, delegacion.Numero,
                        delegacion.Colonia, delegacion.CodigoPostal, delegacion.Telefono,
                        delegacion.Correo, delegacion.TipoDelegacion, delegacion.IdMunicipio,
                        delegacion.IdDelegacion);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Delegacion modificarDelegacion(Delegacion delegacion):");
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

        public static void eliminarDelegacion(Delegacion delegacion)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("DELETE FROM SistemaVehicular.dbo.Delegacion " +
                        "WHERE idDelegacion = {0}", delegacion.IdDelegacion);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DelegacionDAO eliminarDelegacion(Delegacion delegacion):");
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
