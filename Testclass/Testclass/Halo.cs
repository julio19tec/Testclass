using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testclass
{
    class Halo: ResidentEvil
    {
        string duracion;

    public string Duracion
    {
        get
        {
            return duracion;
        }
        set
        {
            duracion = value;
        }
    }

        public Halo(): base()
        {
            duracion = "";
        }
        public override string ToString()
        {
            return duracion + " " + base.ToString();
        }



    }
    

    
}
