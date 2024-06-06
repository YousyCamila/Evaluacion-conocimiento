using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    using System.Collections.Generic;

    public class Repositorio<T>
    {
        public List<T> Elementos { get; set; }

        public Repositorio()
        {
            Elementos = new List<T>();
        }
    }
}
