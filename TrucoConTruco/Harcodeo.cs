using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoConTruco
{
    public static class Harcodeo
    {
        public static int inicio;


        public static Mazo MazoHarcodeado()
        {
            Mazo mazo = new Mazo("Baraja Española");

            mazo.mazoDeCartas.Add(new Carta(1, "Espada", 1, 1,1));
            mazo.mazoDeCartas.Add(new Carta(2,"Basto",2,1,1));
            mazo.mazoDeCartas.Add(new Carta(3, "Espada", 3, 7,7));
            mazo.mazoDeCartas.Add(new Carta(4, "Oro", 4, 7,7));
            mazo.mazoDeCartas.Add(new Carta(5,"Espada",5, 3,3));
            mazo.mazoDeCartas.Add(new Carta(6, "Oro", 5, 3,3));
            mazo.mazoDeCartas.Add(new Carta(7, "Basto", 5, 3,3));
            mazo.mazoDeCartas.Add(new Carta(8, "Copa", 5, 3,3));
            mazo.mazoDeCartas.Add(new Carta(9, "Espada", 6, 2,2));
            mazo.mazoDeCartas.Add(new Carta(10,"Oro",6, 2,2));
            mazo.mazoDeCartas.Add(new Carta(11,"Basto",6,2,2));
            mazo.mazoDeCartas.Add(new Carta(12, "Copa", 6, 2,2));
            mazo.mazoDeCartas.Add(new Carta(13, "Oro", 7, 1,1));
            mazo.mazoDeCartas.Add(new Carta(14,"Copa",7,1,1));
            mazo.mazoDeCartas.Add(new Carta(15, "Espada", 8, 12,0));
            mazo.mazoDeCartas.Add(new Carta(16,"Oro",8,12,0));
            mazo.mazoDeCartas.Add(new Carta(17, "Basto", 8, 12,0));
            mazo.mazoDeCartas.Add(new Carta(18, "Copa",8,12,0));
            mazo.mazoDeCartas.Add(new Carta(19, "Espada", 9, 11,0));
            mazo.mazoDeCartas.Add(new Carta(20,"Oro",9,11,0));
            mazo.mazoDeCartas.Add(new Carta(21, "Basto", 9, 11,0));
            mazo.mazoDeCartas.Add(new Carta(22,"Copa",9,11,0));
            mazo.mazoDeCartas.Add(new Carta(23, "Espada", 10, 10,0));
            mazo.mazoDeCartas.Add(new Carta(24,"Oro",10,10,0));
            mazo.mazoDeCartas.Add(new Carta(25, "Basto", 10, 10,0));
            mazo.mazoDeCartas.Add(new Carta(26,"Copa",10,10,0));
            mazo.mazoDeCartas.Add(new Carta(27, "Basto", 11, 7,7));
            mazo.mazoDeCartas.Add(new Carta(28, "Copa", 11, 7,7));
            mazo.mazoDeCartas.Add(new Carta(29, "Espada", 12, 6,6));
            mazo.mazoDeCartas.Add(new Carta(30,"Oro",12, 6,6));
            mazo.mazoDeCartas.Add(new Carta(31,"Basto",12,6,6));
            mazo.mazoDeCartas.Add(new Carta(32, "Copa", 12, 6,6));
            mazo.mazoDeCartas.Add(new Carta(33, "Espada", 13, 5,5));
            mazo.mazoDeCartas.Add(new Carta(34, "Oro", 13, 5,5));
            mazo.mazoDeCartas.Add(new Carta(35,"Basto",13,5,5));
            mazo.mazoDeCartas.Add(new Carta(36, "Copa", 13, 5,5));
            mazo.mazoDeCartas.Add(new Carta(37, "Espada", 14, 4,4));
            mazo.mazoDeCartas.Add(new Carta(38, "Oro", 14, 4,4));
            mazo.mazoDeCartas.Add(new Carta(39,"Basto",14,4,4));
            mazo.mazoDeCartas.Add(new Carta(40, "Copa", 14, 4,4));

            return mazo;

        }   






    }
}
