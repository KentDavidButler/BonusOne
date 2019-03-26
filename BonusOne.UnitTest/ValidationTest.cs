using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BonusOne.UnitTest
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void IsNum_ProvidValidStrNum_ResultsTrue()
        {
            //arrange
            //initialize the objects
            string numStr = "25";
            bool result;

            //act
            //call the method we are going to test
            var numInt = Validation.IsNum(numStr);

            //assert
            if (numInt >= 0)
                result = true;
            else
                result = false;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNum_ProvidInvalidStr_ResultsTrue()
        {
            //arrange
            //initialize the objects
            string numStr = "dkl";
            bool result;

            //act
            //call the method we are going to test
            var numInt = Validation.IsNum(numStr);

            //assert
            if (numInt >= 0)
                result = true;
            else
                result = false;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNum_ProvidNullStr_ResultsTrue()
        {
            //arrange
            //initialize the objects
            string numStr = "";
            bool result;

            //act
            //call the method we are going to test
            var numInt = Validation.IsNum(numStr);

            //assert
            if (numInt >= 0)
                result = true;
            else
                result = false;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBetweenZeroAndHund_ProvidZeroNum_ResultsTrue()
        {
            //arrange
            //initialize the objects
            int num = 0;
            bool result;

            //act
            //call the method we are going to test
            result = Validation.IsBetweenZeroAndHund(num);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBetweenZeroAndHund_ProvidHundoNum_ResultsTrue()
        {
            //arrange
            //initialize the objects
            int num = 100;
            bool result;

            //act
            //call the method we are going to test
            result = Validation.IsBetweenZeroAndHund(num);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBetweenZeroAndHund_ProvidNegativeNum_ResultsTrue()
        {
            //arrange
            //initialize the objects
            int num = -1;
            bool result;

            //act
            //call the method we are going to test
            result = Validation.IsBetweenZeroAndHund(num);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBetweenZeroAndHund_ProvidHundoOneNum_ResultsTrue()
        {
            //arrange
            //initialize the objects
            int num = 101;
            bool result;

            //act
            //call the method we are going to test
            result = Validation.IsBetweenZeroAndHund(num);

            //assert
            Assert.IsFalse(result);
        }

    }
}
