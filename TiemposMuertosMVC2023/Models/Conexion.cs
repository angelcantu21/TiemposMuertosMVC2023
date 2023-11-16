using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TiemposMuertosMVC2023.Models
{
    public class Conexion
    {
        //Cadena de conexion local
        //SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=TMEnsamble;user Id=TIRETECH2\uic68743;Password=;Integrated Security=True");

        //Cadena de conexion a servidor
        SqlConnection con = new SqlConnection("Data Source=10.11.130.37,1433; Initial Catalog=TMEnsamble;user Id=sa;Password=Ap0d4c@!!;Network Library=DBMSSOCN");


        //Realiza la conexion
        public SqlConnection conexion()
        {
            SqlConnection conn = con;
            return conn;
        }

        //Metodo para abrir conexion
        public void Open()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Metodo que cierra la conexion sqlserver
        public void Close()
        {
            con.Close();
        }
    }
}