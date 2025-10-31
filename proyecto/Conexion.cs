﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "vinateria";
            string usuario = "root";
            string password = "pekotron123";
            // se crea la cadena conexión con los datos anteriormente guardados
            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";

            try // se intenta la conexión
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message); // en caso de que no se conecte a mysql da este mensaje
                return null;
            }
        }
    }
}
