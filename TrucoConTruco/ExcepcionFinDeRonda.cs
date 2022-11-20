using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public class ExcepcionFinDeRonda : Exception
    {

        public ExcepcionFinDeRonda(string mensaje) : base(mensaje)
        {

        }



    }
}
