using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testclass
{
    class ResidentEvil : Videojuegos
    {
        string fabricante;



        public string Fabricante
        {
            get
            {
                return fabricante;
            }
            set
            {
                fabricante = value;
            }
        }

        public ResidentEvil(): base()
        {
            Fabricante = "";
        }

        public override string ToString()
        {
            return fabricante + " " + base.ToString();
        }

    }
}
