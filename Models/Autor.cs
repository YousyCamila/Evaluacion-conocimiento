using Models;

namespace Models
{
    public class Autor : Persona

    {
        public List<Libro> LibrosEscritos { get; set; }

        public Autor(string nombre, string email)
            :base(nombre, email)    
        {
            this.LibrosEscritos = new List<Libro>();
        }
    }
} 