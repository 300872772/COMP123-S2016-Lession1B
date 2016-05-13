using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static COMP123_S2016_Lession1B.Program;

namespace LessonTestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {

        /**
         * This class is used for to test lesson 1 project
         * Used for development only
         * 
         * @class lessonUnitTest
         * */

        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedtestResult= "Enter UserName: ";

            //Act
            actualResult = OutputStringToConsole(outputString, hasNewLine);



            //Asseert
            Assert.AreEqual(expectedtestResult, actualResult);
        }
    }
}
