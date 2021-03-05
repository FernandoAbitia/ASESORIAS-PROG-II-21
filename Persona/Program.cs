using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        private ManejaPersonas MP;
        private CapaPersona C;

        public Program()
        {
            MP = new ManejaPersonas();
            C = new CapaPersona(MP);
            C.Menu();
        }

        static void Main(string[] args)
        {
           new Program();
        }
    }
}
