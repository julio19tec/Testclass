using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testclass
{
    class Videojuegos:Object
    {
        // variables
        
        protected int nombre;
        

        public int Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
       

        

        //constructores
        public Videojuegos()
        {
            nombre = 0;
        }

        public override string ToString()
        {
            return nombre + "";
        }
        


        
    }
}
