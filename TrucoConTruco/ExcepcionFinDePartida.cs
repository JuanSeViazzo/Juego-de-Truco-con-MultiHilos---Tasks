using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public class ExcepcionFinDePartida : Exception
    {

        public ExcepcionFinDePartida(string mensaje) : base(mensaje)
        {

        }



    }
}
