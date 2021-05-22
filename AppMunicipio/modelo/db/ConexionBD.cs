using System;
using System.Data.SqlClient;

namespace AppMunicipio.modelo.db
{
    class ConexionBD
    {
        private static String SERVER = "localhost";
        private static String PORT = "1433";
        private static String DATABASE = "SistemaVehicular";
        private static String USER = "usuario_sv";
        private static String PASSWORD = "0123456789";

        public static SqlConnection getConecction()
        {
            SqlConnection conn = null;

            try
            {
                String urlconn = String.Format(
                    "Data Source={0}, {1};" +
                    "Network Library=DBMSSOCN;" +
                    "User ID={3};" +
                    "Password={4};",
                    SERVER, PORT, DATABASE, USER, PASSWORD);
                conn = new SqlConnection(urlconn);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción Conexión BD: ");
                Console.WriteLine(e.Message);
                Console.WriteLine(" -------------------------------------- \n");
            }
            Console.WriteLine("\nConexión exitosa\n");
            return conn;
        }
    }
}
