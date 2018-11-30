using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pico_y_Placa_Predictor.Tests
{
    [TestClass()]
    public class FormCheckerTests
    {
        #region License Plate Tests
        [TestMethod()]
        [DataRow("ASD - 123")]
        public void LicensePlateVerifier_PlateNumberIncomplete_Return2(String licensePlateNumber)
        {
            //Arrange
            FormChecker checker = new FormChecker();
            //Act
            var len = licensePlateNumber.Length == 10;
            var result = checker.licensePlateVerifierTest(licensePlateNumber) == 2;
            //Assert
            Assert.IsFalse(len);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aSD - 4583")]
        public void LicensePlateVerifier_FirstLetterLowercase_Return1(String licensePlateNumber)
        {
            //Arrange
            FormChecker checker = new FormChecker();
            //Act
            var result = checker.licensePlateVerifierTest(licensePlateNumber) == 1;
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("AsD - 4583")]
        public void LicensePlateVerifier_SecondLetterLowercase_Return1(String licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            var result = checker.licensePlateVerifierTest(licensePlateNumber) == 1;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("ASd - 4583")]
        public void LicensePlateVerifier_ThirdLetterLowercase_Return1(String licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            var result = checker.licensePlateVerifierTest(licensePlateNumber) == 1;
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("asd - 4583")]
        public void LicensePlateVerifier_ThreeLettersLowercase_Return1(String licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            var result = checker.licensePlateVerifierTest(licensePlateNumber) == 1;
            Assert.IsTrue(result);
        }
        #endregion

        #region Date-Time Tests
        [TestMethod()]
        [DataRow("36/15/201","25:65","ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_DateIncomplete_Return1(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 1, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate,givenTime,licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("36/15/1990", "25:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_DayOutOfBounds_Return2(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 2, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("04/15/1990", "25:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_MonthOutOfBounds_Return3(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 3, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("04/12/1990", "25:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_YearOutOfBounds1_Return4(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 4, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("04/12/3000", "25:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_YearOutOfBounds2_Return4(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 4, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("04/12/2020", "25:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_HourOutOfBounds_Return5(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 5, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("04/12/2020", "15:65", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_MinutesOutOfBounds_Return6(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 6, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        [TestMethod()]
        [DataRow("30/11/2018", "04:33", "ASD - 1234")]
        public void dateTimeVerifierVerdictEngine_DateBeforeRightNow_Return7(string givenDate, string givenTime, string licensePlateNumber)
        {
            FormChecker checker = new FormChecker();
            Assert.AreEqual(expected: 7, actual: checker.dateTimeVerifierVerdictEngineTest(givenDate, givenTime, licensePlateNumber));
        }

        #endregion
    }
}   