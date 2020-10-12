using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class Waiter
    {
        public int IdMesero { get; set; }
        public string Name { get; set; }

        public Waiter()
        {
        }

        public Waiter(int idMesero, string name)
        {
            IdMesero = idMesero;
            Name = name;
        }
    }
}
