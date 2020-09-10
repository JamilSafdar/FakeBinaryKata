using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeBinaryKata
{
    [TestClass]
    public class FakeBinaryTest
    {
        [TestMethod]
        public void GivenAStringOfDigits_ReturnBinaryZeroAndOnes()
        {
            //arrange
            var digitsString = "45385593107843568";
            var expectedBinary = "01011110001100111";

            //act
            var actualBinary =  Converter.DigitsStringToBinary(digitsString);

            //assert
            Assert.AreEqual(expectedBinary, actualBinary);
        }

        [TestMethod]
        public void GivenASecondStringOfDigits_ReturnBinaryZeroAndOnes()
        {
            //arrange
            var digitsString = "366058562030849490134388085";
            var expectedBinary = "011011110000101010000011011";

            //act
            var actualBinary = Converter.DigitsStringToBinary(digitsString);

            //assert
            Assert.AreEqual(expectedBinary, actualBinary);
        }

        [TestMethod]
        public void GivenAStringOfLetters_ReturnBinaryZeroAndOnes()
        {
            //arrange
            var digitsString = "shafalknla";
            var expectedBinary = "shafalknla";

            //act
            var actualBinary = Converter.DigitsStringToBinary(digitsString);

            //assert
            Assert.AreEqual(expectedBinary, actualBinary);
        }
    }
}
