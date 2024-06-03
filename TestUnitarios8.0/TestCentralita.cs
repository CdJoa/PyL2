using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaCentralita;

namespace CentralitaTests
{
    [TestClass]
    public class CentralitaTests
    {
        [TestMethod]
        public void SonLlamadasIgualesTest()
        {
            //Arrange
            //Todos mismo datos de origen y destino.
            Centralita central = new Centralita("Yago Center");
            Local llamadaLocal01 = new Local("42121743", 50f, "1136153288", 5000f);
            Local llamadaLocal02 = new Local("42121743", 15f, "1136153288", 1000f);
            Provincial llamadaProvincial01 = new Provincial("42121743", Provincial.Franja.Franja_3, 50f, "1136153288");
            Provincial llamadaProvincial02 = new Provincial("42121743", Provincial.Franja.Franja_3, 100f, "1136153288");

            //Act

            //Assert
            Assert.IsTrue(llamadaLocal01 == llamadaLocal02, "Local calls with the same origin and destination should be equal.");
            Assert.IsTrue(llamadaProvincial01 == llamadaProvincial02, "Provincial calls with the same origin, destination, and franja should be equal.");
            Assert.IsFalse(llamadaLocal01 == llamadaProvincial01, "Local and Provincial calls should not be equal.");
            Assert.IsFalse(llamadaProvincial01 == llamadaLocal01, "Provincial and Local calls should not be equal.");
        }
    }
}
