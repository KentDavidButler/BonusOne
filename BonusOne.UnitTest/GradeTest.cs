using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BonusOne.UnitTest
{
    [TestClass]
    public class GradeTest
    {
        [TestMethod]
        public void Constructor_ConstructorEmpty_ResultsTrue()
        {
            //arrange
            Grade test = new Grade();

            //act

            //assert
            Assert.AreEqual("F", test.GetGradeLetter());
        }

        [TestMethod]
        public void Constructor_ConstructorWith100_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(100);

            //act

            //assert
            Assert.AreEqual("A+", test.GetGradeLetter() );
        }

        [TestMethod]
        public void Constructor_ConstructorWithNegative_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(-1);
            string expected = "Cannot be Negative";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter() );
        }

        [TestMethod]
        public void Constructor_ConstructorWithOverHundred_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(1234);
            string expected = "Cannot be over 100";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter());
        }

        [TestMethod]
        public void Constructor_ConstructorWithAPlus_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(97);
            string expected = "A+";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter());
        }

        [TestMethod]
        public void Constructor_ConstructorWithBSolid_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(85);
            string expected = "B ";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter());
        }

        [TestMethod]
        public void Constructor_ConstructorWithCMinus_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(71);
            string expected = "C-";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter());
        }

        [TestMethod]
        public void Constructor_ConstructorWithDPlus_ResultsTrue()
        {
            //arrange
            Grade test = new Grade(69);
            string expected = "D+";

            //act

            //assert
            Assert.AreEqual(expected, test.GetGradeLetter());
        }
    }
}
