using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace proyecto
{
    static class CRUD
    {
        // 🔹 CREATE
        public static void RegistrarVino(Vino vino)
        {
            string consulta = @"INSERT INTO vino (nombre, precio, grado, fecha_ingreso, categoria)
                            VALUES (@nombre, @precio, @gradosAlcohol, @fechaIngrso, @categoriaVino)";
            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                try
                {
                    conexionBD.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@nombre", vino.nombre);
                        comando.Parameters.AddWithValue("@precio", vino.precio);
                        comando.Parameters.AddWithValue("@gradosAlcohol", vino.gradosAlcohol);
                        comando.Parameters.AddWithValue("@fechaIngrso", vino.fechaIngrso);
                        comando.Parameters.AddWithValue("@categoriaVino", vino.categoriaVino);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Vino registrado correctamente.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar el vino: " + ex.Message);
                }
            }
        }

        // 🔹 READ
        public static List<Vino> ObtenerVinos()
        {
            List<Vino> lista = new List<Vino>();
            string consulta = "SELECT id, nombre, precio, grado, fecha_ingreso, categoria FROM vino";

            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                try
                {
                    conexionBD.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vino vino = new Vino(
        reader.GetInt32("id"),
        reader.GetString("nombre"),
        reader.GetDecimal("precio"),
        reader.GetDecimal("grado"),
        reader.GetDateTime("fecha_ingreso"),
        reader.GetString("categoria")
    );

                            lista.Add(vino);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener vinos: " + ex.Message);
                }
            }

            return lista;
        }

        // 🔹 UPDATE
        public static void ActualizarVino(Vino vino)
        {
            string consulta = @"UPDATE vino 
                            SET nombre=@nombre, precio=@precio, grado=@gradosAlcohol, fecha_ingreso=@fechaIngrso, categoria=@categoriaVino 
                            WHERE id=@id";

            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                try
                {
                    conexionBD.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@id", vino.id);
                        comando.Parameters.AddWithValue("@nombre", vino.nombre);
                        comando.Parameters.AddWithValue("@precio", vino.precio);
                        comando.Parameters.AddWithValue("@gradosAlcohol", vino.gradosAlcohol);
                        comando.Parameters.AddWithValue("@fechaIngrso", vino.fechaIngrso);
                        comando.Parameters.AddWithValue("@categoriaVino", vino.categoriaVino);

                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show(filas > 0 ? "Vino actualizado correctamente." : "No se encontró el vino para actualizar.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el vino: " + ex.Message);
                }
            }
        }

        // 🔹 DELETE
        public static void EliminarVino(int id)
        {
            string consulta = "DELETE FROM vino WHERE id=@id";
            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                try
                {
                    conexionBD.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show(filas > 0 ? "Vino eliminado correctamente." : "No se encontró el vino para eliminar.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar el vino: " + ex.Message);
                }
            }
        }

        // 🔹 1️⃣ Obtener por ID
        public static Vino Obtener(int id)
        {
            string consulta = "SELECT * FROM vino WHERE id = @id";
            Vino vino = null;

            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vino = new Vino(
                                reader.GetInt32("id"),
                                reader.GetString("nombre"),
                                reader.GetDecimal("precio"),
                                reader.GetDecimal("grado"),
                                reader.GetDateTime("fecha_ingreso"),
                                reader.GetString("categoria")
                            );
                        }
                    }
                }
            }
            return vino;
        }
        public static List<Vino> Obtener(string nombre = null, string categoria = null)
        {
            List<Vino> lista = new List<Vino>();

            // 🧠 Construimos la consulta de forma dinámica
            string consulta = "SELECT * FROM vino WHERE 1=1";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND nombre LIKE @nombre";

            if (!string.IsNullOrEmpty(categoria))
                consulta += " AND categoria = @categoria";

            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    if (!string.IsNullOrEmpty(nombre))
                        comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                    if (!string.IsNullOrEmpty(categoria))
                        comando.Parameters.AddWithValue("@categoria", categoria);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Vino(
                                reader.GetInt32("id"),
                                reader.GetString("nombre"),
                                reader.GetDecimal("precio"),
                                reader.GetDecimal("grado"),
                                reader.GetDateTime("fecha_ingreso"),
                                reader.GetString("categoria")
                            ));
                        }
                    }
                }
            }

            return lista;
        }
    }
}
