using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace TiemposMuertosMVC2023.Models
{
    public class Ordenes : Conexion
    {
        public int IdOrden { get; set; }
        public String Prioridad { get; set; }
        public String Maquina { get; set; }
        public String ComentarioInicial { get; set; }
        public String Area { get; set; }
        public String Causa { get; set; }
        public String HoraInicio { get; set; }
        public String HoraInicioAtencion { get; set; }
        public String HoraFinalAtencion { get; set; }
        public String HoraInicioLiberacion { get; set; }
        public String TiempoMuerto { get; set; }
        public String Personal { get; set; }
        public String Estatus { get; set; }

        public List<Ordenes> getOrdenes()
        {
            List<Ordenes> lst = new List<Ordenes>();
            String query = "";

            query = $"SELECT * FROM view_layout_3";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion());

                Open();

                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    Ordenes or = new Ordenes();
                    or.IdOrden = leer.GetInt32(0);
                    or.Prioridad = leer.GetString(1);
                    or.Maquina = leer.GetString(2);
                    or.ComentarioInicial = leer.GetString(3);
                    or.Area = leer.GetString(4);
                    or.Causa = leer.GetString(5);
                    or.HoraInicio = leer.GetString(6);

                    if (!leer.IsDBNull(7))
                    {
                        or.HoraInicioAtencion = leer.GetString(7);
                    }
                    else
                    {
                        or.HoraInicioAtencion = "-";
                    }

                    if (!leer.IsDBNull(8))
                    {
                        or.HoraFinalAtencion = leer.GetString(8);
                    }
                    else
                    {
                        or.HoraFinalAtencion = "-";
                    }

                    if (!leer.IsDBNull(9))
                    {
                        or.HoraInicioLiberacion = leer.GetString(9);
                    }
                    else
                    {
                        or.HoraInicioLiberacion = "-";
                    }

                    or.TiempoMuerto = leer.GetString(10);
                    or.Estatus = leer.GetString(11);
                    if (!leer.IsDBNull(12))
                    {
                        or.Personal = leer.GetString(12);
                    }
                    if (!leer.IsDBNull(13))
                    {
                        or.Personal = leer.GetString(13);
                    }
                    if (!leer.IsDBNull(14))
                    {
                        or.Personal = leer.GetString(14);
                    }

                    lst.Add(or);
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