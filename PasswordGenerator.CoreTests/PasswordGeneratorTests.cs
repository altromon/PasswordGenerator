using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Core.Tests
{
    [TestClass()]
    public class PasswordGeneratorTests
    {
        KeyGenerator sut;

        [TestMethod()]
        [DataRow(5)]
        [DataRow(100)]
        [DataRow(1000)]
        public void GenerateTest(int length)
        {
            //Setup
            sut = new KeyGenerator(length);

            //Act
            sut.Generate();

            //Assert
            Assert.AreEqual(length, sut.Password.Length);
        }
    }
}