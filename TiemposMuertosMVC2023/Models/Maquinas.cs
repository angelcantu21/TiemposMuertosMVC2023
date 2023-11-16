using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TiemposMuertosMVC2023.Models
{
    public class Maquinas : Conexion
    {
        public int IdMaquina { get; set; }
        public String Nombre { get; set; }
        public String Zona { get; set; }
        public bool Estatus { get; set; }
        public String Area { get; set; }
        public String Reporte { get; set; }
        public String Icono { get; set; }

        public List<Maquinas> getMaquinas()
        {

            List<Maquinas> lst = new List<Maquinas>();
            String query = "";

            query = $"SELECT * FROM SeleccionMaquinas";


            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion());

                Open();

                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    Maquinas ma = new Maquinas();
                    ma.IdMaquina = leer.GetInt32(0);
                    ma.Nombre = leer.GetString(1);
                    ma.Zona = leer.GetString(2);
                    ma.Estatus = leer.GetBoolean(3);
                    ma.Area = leer.GetString(4);
                    ma.Reporte = leer.GetString(5);
                    ma.Icono = leer.GetString(6);

                    lst.Add(ma);
                }

                leer.Close();

                Close();
            }
            catch (Exception ex)
            {

            }


            return lst;
        }

    }
}