using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;
using System.Xml;
using System.Xml.Linq;


namespace MathUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region DataInfo_Default_Constructor
        [TestMethod]
        public void Test_DataInfoDefault_Constructor()
        {
            // Arrange
            DataInfo dataInfo = new DataInfo();
          
            // Act
            string actualName = dataInfo.Name;
            string  actualOperator = dataInfo.Oper;
            int actualValueOne = dataInfo.ValueOne;
            int actualValueTwo = dataInfo.ValueTwo;

            // Assert
            const string expectedName = null;
            const string expectedOperator = null;
            const int expectedValueOne = 0;
            const int expectedValueTwo = 0;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedOperator, actualOperator);
            Assert.AreEqual(expectedValueOne, actualValueOne);
            Assert.AreEqual(expectedValueTwo, actualValueTwo);

        }
        #endregion DataInfo_Default_Constructor

        #region DataInfo_Constructor
        [TestMethod]
        public void Test_DataIn_Constructor()
        {
            // Arrange
            DataInfo dataInfo = new DataInfo("Susan", "SUM", 4, 5);

            // Act
            string actualName = dataInfo.Name;
            string actualOperator = dataInfo.Oper;
            int actualValueOne = dataInfo.ValueOne;
            int actualValueTwo = dataInfo.ValueTwo;

            // Assert
            const string expectedName = "Susan";
            const string expectedOperator = "SUM";
            const int expectedValueOne = 4;
            const int expectedValueTwo = 5;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedOperator, actualOperator);
            Assert.AreEqual(expectedValueOne, actualValueOne);
            Assert.AreEqual(expectedValueTwo, actualValueTwo);

        }
        #endregion DataInfo_Constructor

        #region Program_Power
        [TestMethod]
        public void Test_Power()
        {
            // Arrange
            int baseNumber = 2;
            int expNumber = 3;


            // Act
            int actualPower = Program.Pow(baseNumber, expNumber);

            // Assert
            const int expectedPower = 8;
           
            Assert.AreEqual(expectedPower, actualPower);




        }
        #endregion Program_ConstantInt

        #region Program_DoMath
        [TestMethod]
        public void Test_DoMath()
        {
            // Arrange
            DataInfo calSUM = new DataInfo("Susan", "SUM", 5, 4);
            DataInfo calSUB = new DataInfo("Mike", "SUB", 9, 5);
            DataInfo calMULTIPLY = new DataInfo("Mike", "MULTIPLY", 9, 5);
            DataInfo calDIVIDE = new DataInfo("Mike", "DIVIDE", 9, 3);
            DataInfo calPower = new DataInfo("Coco", "Power", 2, 3);
            DataInfo calInvalidOperator = new DataInfo("Mike", "Mean", 9, 3);



            // Act
            int actualSUM = Program.doMath(calSUM);
            int actualSUB = Program.doMath(calSUB);
            int actualMULTIPLY = Program.doMath(calMULTIPLY);
            int actualDIVIDE = Program.doMath(calDIVIDE);
            int actualPower = Program.doMath(calPower);
            int actualInvalidOperator = Program.doMath(calInvalidOperator);

            // Assert
            const int expectedSUM = 9;
            const int expectedSUB = 4;
            const int expectedMULTIPLY = 45;
            const int expectedDIVIDE = 3;
            const int expectedPower = 8;
            const int expectedInvalidOperator = -999999;

            Assert.AreEqual(expectedSUM, actualSUM);
            Assert.AreEqual(expectedSUB, actualSUB);
            Assert.AreEqual(expectedMULTIPLY, actualMULTIPLY);
            Assert.AreEqual(expectedDIVIDE, actualDIVIDE);
            Assert.AreEqual(expectedPower, actualPower);
            Assert.AreEqual(expectedInvalidOperator, actualInvalidOperator);

        }
        #endregion Program_DoMath

        #region Program_GetOperater
        [TestMethod]
        public void Test_GetOperater()
        {
            // Arrange
            string opSUM = "SUM";
            string opSUB = "SUB";
            string opMULTIPLY = "MULTIPLY";
            string opDIVIDE = "DIVIDE";
            string opInvalid = "%";



            // Act
            string actualSUM = Program.getOperater(opSUM);
            string actualSUB = Program.getOperater(opSUB);
            string actualMULTIPLY = Program.getOperater(opMULTIPLY);
            string actualDIVIDE = Program.getOperater(opDIVIDE);
            string actualInvalidOperator = Program.getOperater(opInvalid);

            // Assert
            const string expectedSUM = "+";
            const string expectedSUB = "-";
            const string expectedMULTIPLY = "*";
            const string expectedDIVIDE = "/";
            const string expectedInvalid = "Invalid Operator";

            Assert.AreEqual(expectedSUM, actualSUM);
            Assert.AreEqual(expectedSUB, actualSUB);
            Assert.AreEqual(expectedMULTIPLY, actualMULTIPLY);
            Assert.AreEqual(expectedDIVIDE, actualDIVIDE);
            Assert.AreEqual(expectedInvalid, actualInvalidOperator);

        }
        #endregion Program_GetOperater

        #region Program_PrintResult
        [TestMethod]
        public void Test_PrintResult()
        {
            // Arrange
            DataInfo data = new DataInfo("Susan", "SUM", 5, 4);
            int mathResult = Program.doMath(data);


            // Act
            string actualPrintResult = Program.printResult(data, mathResult);
           
            // Assert
            const string expectedPrintResult = "Susan--SUM:  5 + 4 = 9" ; 
           

            Assert.AreEqual(expectedPrintResult, actualPrintResult);
          

        }
        #endregion Program_PrintResult



        #region Program_CostantInt
        [TestMethod]
        public void Test_CostantInt()
        {
            // Arrange
            String[] actualArgs = Environment.GetCommandLineArgs();
           

            var document = new XDocument();
            XDocument data = XDocument.Load("math.xml");

           string actual =  Program.getOperater("SUM");


            // Act
         //   Program.Main(null);
            


            // Assert

            Assert.IsNotNull(actualArgs);
            Assert.IsNotNull(data);
            Assert.AreEqual("+", actual);
            



        }
        #endregion Program_ConstantInt

    }
}
