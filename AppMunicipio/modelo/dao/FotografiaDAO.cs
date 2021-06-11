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
    public class FotografiaDAO
    {
        public static void guardarImagen(Fotografia fotografia)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;

                    String query = "INSERT INTO SistemaVehicular.dbo.Fotografia (foto, idReporte) " +
                        "VALUES(@Foto, @IdReporte)";
                    command = new SqlCommand(query, conn);
                    command.Parameters.Add(new SqlParameter("@Foto", fotografia.Foto));
                    command.Parameters.Add(new SqlParameter("@IdReporte", fotografia.IdReporte));
                    dataReader = command.ExecuteReader();

                    Console.WriteLine(query);
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción guardarImagen(Fotografia fotografia):");
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
