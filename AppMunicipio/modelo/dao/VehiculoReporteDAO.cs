using AppMunicipio.modelo.db;
using AppMunicipio.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace AppMunicipio.modelo.dao
{
    class VehiculoReporteDAO
    {

        public static void registrarVehiculoReporte(VehiculoReporte vehiculoReporte)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Vehiculo_Reporte " +
                        "(Vehiculo_idVehiculo, Reporte_idReporte) " +
                        "VALUES({0}, {1});",
                        vehiculoReporte.IdVehiculo, vehiculoReporte.IdReporte);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción VehiculoReporteDAO registrarVehiculoReporte(VehiculoReporte vehiculoReporte):");
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

        public static List<VehiculoReporte> getVehiculoReporte(Vehiculo vehiculo)
        {
            List<VehiculoReporte> vehiculoReportes = new List<VehiculoReporte>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT s.Vehiculo_idVehiculo, s.Reporte_idReporte " +
                        "FROM SistemaVehicular.dbo.Vehiculo_Reporte s " +
                        "WHERE s.Vehiculo_idVehiculo = {0};", vehiculo.IdVehiculo);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        VehiculoReporte vehiculoReporte = new VehiculoReporte();

                        vehiculoReporte.IdVehiculo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculoReporte.IdReporte = (!dataReader.IsDBNull(1)) ? dataReader.GetInt32(1) : 0;

                        vehiculoReportes.Add(vehiculoReporte);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Vehiculo DAO getVehiculosConductor(Conductor conductor):");
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
            return vehiculoReportes;
        }

    }
}
