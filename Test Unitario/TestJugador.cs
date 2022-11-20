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

            //GIVEN
            string ruta = "C:\\Users\\juans\\source\\JuanSViazzo2DLabo2-TPTruco\\TrucoConTruco\\UI\\bin\\Debug\\net5.0-windows\\Archivos-Serializacion\\Mazo_Serializado.xml";
            XmlSerializadora<Mazo> serializadoraMazoXML = new XmlSerializadora<Mazo>();
            Mazo mazo;
            mazo = serializadoraMazoXML.LeerSerializadora(ruta);

            Jugador jugadorUno = new Jugador("JuanSeñorMatador", true);
            Jugador jugadorDos = new Jugador("NachinTruqueroViejo", true);
            //WHEN
            jugadorUno.RepartirCartas(mazo, jugadorUno, jugadorDos);
            //THEN
            Assert.IsTrue(jugadorUno.mano.Count == 3);

        }

        [TestMethod]
        public void MezclarLasCartas()
        {
            //given
            string rutaAca = "C:\\Users\\juans\\source\\JuanSViazzo2DLabo2-TPTruco\\TrucoConTruco\\UI\\bin\\Debug\\net5.0-windows\\Archivos-Serializacion\\Mazo_Serializado.xml";
            XmlSerializadora<Mazo> xmlSerializadora = new XmlSerializadora<Mazo>();
            Mazo mazoOriginal = xmlSerializadora.LeerSerializadora(rutaAca);
            Mazo mazoMezclado = new Mazo();

            //when
            mazoMezclado.mazoDeCartas = new List<Carta>(mazoOriginal.mazoDeCartas);
            Jugador jugadorUno = new Jugador("JuanSe", true);
            mazoMezclado = jugadorUno.Mezclar(mazoMezclado);

            //then
            bool sonIguales = Enumerable.SequenceEqual(mazoMezclado.mazoDeCartas, mazoOriginal.mazoDeCartas);

            CollectionAssert.AreEquivalent(mazoOriginal.mazoDeCartas, mazoMezclado.mazoDeCartas);

            Assert.IsFalse(sonIguales);



        }
    }
}
