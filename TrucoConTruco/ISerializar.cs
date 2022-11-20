using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public interface ISerializar<T> where T : class, new()
    {

        void EscribirSerializadora(T objeto);
        T LeerSerializadora(string rutaParaLectura);







    }
}
