using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuNote.Domain;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var uConCreateSurvey = new UControlCreateSurvey();

            //Act
            var result = uConCreateSurvey.CalculatePercentage(10, 100);

            //Assert
            Assert.AreEqual(10, result);
        }

    }
}
