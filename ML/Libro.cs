using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Libro
    {
        public int IdLibre { get; set; }
        public string Autor { get; set; }
        public string TItulo { get; set; }
        public string AñoPublicacion { get; set; }
        public string Editorial { get; set; }
        public List<object> libros { get; set; }
    }
   
}
