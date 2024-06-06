using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
        public class Usuario : Persona, IBuscable, IRegistrable
        {
            public List<Prestamo> LibrosPrestados { get; set; }

            public Usuario(string nombre, string email)
            : base(nombre, email) 
            {
                LibrosPrestados = new List<Prestamo>();
            }

        public void Buscar()
        {
            Console.WriteLine($"el libro es {titulo}"); 
        }

        public void Registrar()
        {
            throw new NotImplementedException();
        }
    }
    }
