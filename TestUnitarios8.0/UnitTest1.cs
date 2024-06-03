using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios8._0
{
    [TestClass]
    public class CalculadoraTests
    {
        private Strings calculadora;

        [TestInitialize]
        public void Setup()
        {
            calculadora = new Strings();
        }

        [TestMethod]
        public void Add_EmptyString_ReturnsZero()
        {
            int result = calculadora.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_SingleNumber_ReturnsNumber()
        {
            int result = calculadora.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = calculadora.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_MultipleNumbers_ReturnsSum()
        {
            int result = calculadora.Add("1,2,3,4,5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_MultipleNumbersWithEmptyValues_ReturnsSumIgnoringEmptyValues()
        {
            int result = calculadora.Add("1,,2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Add_NumbersWithNewlineDelimiter_ReturnsSum()
        {
            int result = calculadora.Add("1\n2,3");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Add_NumbersWithMixedDelimiters_ReturnsSum()
        {
            int result = calculadora.Add("1\n2,3\n4,5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_CustomDelimiter_ReturnsSum()
        {
            int result = calculadora.Add("//;\n1;2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_CustomDelimiterWithMultipleNumbers_ReturnsSum()
        {
            int result = calculadora.Add("//;\n1;2;3;4;5");
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_NegativeNumber_ThrowsException()
        {
            try
            {
                calculadora.Add("1,-2,3");
            }
            catch (NegativoNoPermitidoException ex)
            {
                Assert.AreEqual("Negativos no permitidos: -2", ex.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_MultipleNegativeNumbers_ThrowsException()
        {
            try
            {
                calculadora.Add("1,-2,3,-4");
            }
            catch (NegativoNoPermitidoException ex)
            {
                Assert.AreEqual("Negativos no permitidos: -2, -4", ex.Message);
                throw;
            }
        }
    }
}
