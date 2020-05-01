using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Core.Tests
{
    [TestClass()]
    public class CharacterFactoryTests
    {
        [TestMethod()]
        public void GetAsciiCharactersTest_GeneralTest_ExpectedStringSet()
        {
            //Setup
            var expected = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            //Act
            var actual = CharacterFactory.GetAsciiCharacters();

            //Assert
            Assert.AreEqual(expected, string.Concat(actual));
        }
    }
}