using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Vino
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal gradosAlcohol { get; set; }
        public DateTime fechaIngrso { get; set; }
        public string categoriaVino { get; set; } 

        public Vino(int id, string nombre, decimal precio, decimal gradosAlcohol, DateTime fechaIngrso, string categoriaVino)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.gradosAlcohol = gradosAlcohol;
            this.fechaIngrso = fechaIngrso;
            this.categoriaVino = categoriaVino;
        }

    }
}
