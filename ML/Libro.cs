using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string FechaPublicacion { get; set; }
        public string Genero { get; set; }
        public int NumPaginas { get; set; }
        public decimal Precio { get; set; }
        public int Stock {  get; set; }

        public List<Object> Libros { get; set; }
    }
}
