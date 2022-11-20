using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TrucoConTruco;

namespace Test_Unitario
{
    [TestClass]
    public class TestJugador
    {
        [TestMethod]
        public void ReparteLasCartasDeFormaCorrecta()
        {
          //  //GIVEN 
          //  Mazo mazo;
          ////  mazo = Administracion.MazoHarcodeado();
          //  Jugador jugadorUno = new Jugador("JuanSeñorMatador",true);
          //  Jugador jugadorDos = new Jugador("NachinTruqueroViejo",true);
          //  //WHEN
          //  jugadorUno.RepartirCartas(mazo,jugadorUno,jugadorDos);
          //  //THEN
          //  Assert.IsTrue(jugadorUno.mano.Count == 3);

        }

        [TestMethod]
        public void MezclarLasCartas()
        {
            //given
           // Mazo mazoMezclado = new Mazo();
           // Mazo mazoOriginal = Administracion.MazoHarcodeado();

           // //when
           // mazoMezclado.mazoDeCartas = new List<Carta>(mazoOriginal.mazoDeCartas); 
           // Jugador jugadorUno = new Jugador("JuanSe",true);
           // mazoMezclado = jugadorUno.Mezclar(mazoMezclado);

           ////then
           // bool sonIguales = Enumerable.SequenceEqual(mazoMezclado.mazoDeCartas, mazoOriginal.mazoDeCartas);

           // CollectionAssert.AreEquivalent(mazoOriginal.mazoDeCartas, mazoMezclado.mazoDeCartas);
            
           // Assert.IsFalse(sonIguales);

            

        }
    }
}
