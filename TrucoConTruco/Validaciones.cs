using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public static class Validaciones
    {
        private static Exception validarNumero;

        public static bool ValidarString(string dato)
        {

            return !String.IsNullOrEmpty(dato) && (!dato.All(char.IsNumber));
            

        }


        public static bool ValidarSoloDocumento(int dato)
        {
            return dato >= 1000000 && dato <= 99999999;

            
        }


        public static bool ValidarSoloEdad(string dato)
        {
            int valor;
            return !int.TryParse(dato, out valor) && valor > 0 && valor < 150;

        }

        public static bool ValidarSoloNumero(string dato)
        {
            int valor;
            return !int.TryParse(dato, out valor);

        }


        public static string ValidarPassword(string dato)
        {

            Match matchMayusculas = Regex.Match(dato, @"[A-Z]");
            Match matchEspeciales = Regex.Match(dato, @"[ñÑ\-_¿.#¡*@!=]");

            if (dato.Length > 8 && matchEspeciales.Success && matchEspeciales.Success)
            {
                return dato;
            }else
            {
                throw new Exception();
            }



        }

















    }
}
