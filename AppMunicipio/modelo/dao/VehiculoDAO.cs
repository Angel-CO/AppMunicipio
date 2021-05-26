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
    class VehiculoDAO
    {
        public static List<Vehiculo> getVehiculosConductor(Conductor conductor)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT v.idVehiculo, v.marca, v.modelo, v.anio, " +
                        "v.nombreAseguradora, v.numPolizaSeguro, v.numPlaca, v.idConductor " +
                        "FROM SistemaVehicular.dbo.Vehiculo v " +
                        "WHERE idConductor = {0};", conductor.IdConductor);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo();

                        vehiculo.IdConductor = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculo.Marca = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        vehiculo.Modelo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        vehiculo.Anio = (!dataReader.IsDBNull(3)) ? dataReader.GetDateTime(3) : new DateTime();
                        vehiculo.NombreAseguradora = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        vehiculo.NumPolizaSeguro = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        vehiculo.NumPlaca = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        vehiculo.IdConductor = (!dataReader.IsDBNull(7)) ? dataReader.GetInt32(7) : 0;

                        vehiculos.Add(vehiculo);
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
            return vehiculos;
        }
    }
}