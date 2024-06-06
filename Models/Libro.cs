using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro 
    {
        public string Titulo { get; set; }
        
        public List<Autor> Autores { get; set; }

        public int CantPaginas { get; set; }

        public bool EstadoLibro { get; set; }

        public List<Capitulo> Capitulos { get; set; }

        public Libro(string nombre, string email, string titulo, int cantPaginas, bool estadoLibro)
        
        {
            this.Titulo = titulo;
            this.CantPaginas = cantPaginas;
            this.EstadoLibro = estadoLibro;
        }


    }

}
