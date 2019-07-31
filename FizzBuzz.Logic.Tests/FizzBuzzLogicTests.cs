using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logic.Tests
{
    public class FizzBuzzLogicTests
    {
        [Test]
        public void Given_The_First_Result_I_Should_See_1()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();        //start an instance of a class

            // Act
            var result = fizzBuzzLogic.Get();               //function attached to a class instance

            // Assert
            Assert.AreEqual("1", result[0]);    //state what it is expected to happen
        }

        [Test]
        public void Given_The_Second_Result_I_Should_See_2()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("2", result[1]);
        }

        [Test]
        public void Given_The_Third_Result_I_Should_See_Fizz()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("Fizz", result[2]);
        }

        [Test]
        public void Given_The_Fifth_Result_I_Should_See_Buzz()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("Buzz", result[4]);
        }
        [Test]
        public void Given_The_Fifteenth_Result_I_Should_See_FizzBuzz()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("FizzBuzz", result[14]);
        }

        [Test]
        public void Given_The_Sixtieth_Result_I_Should_See_FizzBuzz()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("FizzBuzz", result[59]);
        }
        [Test]
        public void Given_The_Hundredth_Result_I_Should_See_Buzz()
        {
            // Arrange
            var fizzBuzzLogic = new FizzBuzzLogic();

            // Act
            var result = fizzBuzzLogic.Get();

            // Assert
            Assert.AreEqual("Buzz", result[99]);
        }
    }
}
