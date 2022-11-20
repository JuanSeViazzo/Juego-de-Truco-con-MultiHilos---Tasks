using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TrucoConTruco;

namespace Test_Unitario
{


    [TestClass]
    public class TestLogicaDeRonda
    {
      
        [TestMethod]
        public void CalcularTantosConDosCartasMismoPalo()
        {
            List<Carta> cartasParaTanto = new List<Carta>() { new Carta(1, "basto", 10, 5, 0) ,new Carta(1, "Espada", 1, 1, 1),
            new Carta(2, "Basto", 2, 1, 1),new Carta(3, "Espada", 3, 7,7)};


            LogicaDeRonda logicaDeRonda = new LogicaDeRonda();
            int tantos = logicaDeRonda.CalcularTantos(cartasParaTanto);

            Assert.IsTrue(28 == tantos);

        }
        [TestMethod]
        public void CalcularTantosConTresCartasMismoPalo()
        {
            List<Carta> cartasParaTanto = new List<Carta>() { new Carta(29, "Espada", 12, 6,6) 
                ,new Carta(1, "Espada", 1, 1, 1), new Carta(3, "Espada", 3, 7,7)};


            LogicaDeRonda logicaDeRonda = new LogicaDeRonda();
            int tantos = logicaDeRonda.CalcularTantos(cartasParaTanto);

            Assert.IsTrue(33 == tantos);

        }

        [TestMethod]
        public void CalcularTantosConDosFigurasYUnaCarta()
        {
            List<Carta> cartasParaTanto = new List<Carta>() { new Carta(25, "Basto", 10, 10, 0)
                ,new Carta(26, "Copa", 10, 10, 0), new Carta(27, "Basto", 11, 7, 7)};

            LogicaDeRonda logicaDeRonda = new LogicaDeRonda();
            int tantos = logicaDeRonda.CalcularTantos(cartasParaTanto);

            Assert.IsTrue(27 == tantos);

        }



    }




}
