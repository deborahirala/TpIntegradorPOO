using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Integrador_Club.Datos
{
    public class Conexion
    {
        public static string? baseDatos
        {
            get; set;
        }
        public static string? servidor
        {
            get; set;
        }
        public static string? puerto
        {
            get; set;
        }
        public static string? usuario
        {
            get; set;
        }
        public static string? clave
        {
            get; set;
        }
        private static Conexion? con = null;
 
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;
            }

            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null) 
            {
                con = new Conexion();  
            }
            return con;
        }
    }
}
