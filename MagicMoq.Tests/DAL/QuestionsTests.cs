using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagicMoq.DAL;
using Moq;
using System.Collections.Generic;

namespace MagicMoq.Tests.DAL
{
    [TestClass]
    public class QuestionsTests
    {
        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions questions = new Questions();

            Assert.IsNotNull(questions);
        }

        [TestMethod]
        public void EnsureICanCreateAnswersInstance()
        {
            Answers answer = new Answers();

            Assert.IsNotNull(answer);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsAnswersInstance()
        {
            // Hint: Implement a Constructor (for Questions class)
            Questions questions = new Questions();

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {

            // Hint 1: Create an instance of your Answers class
            Answers answer = new Answers();

            // Hint 2: Implement another Constructor (for Questions class)
            Questions questions = new Questions(/* Hint 3: inject an Answers instance here*/ answer);

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureSayHelloReturnsHelloWorld()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>(); // Creates a Mock
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World"); // How to hijack the method call
            /* 
             * a => a.something()
             * same as:
             * function(a) {
             *      return a.something();
             * }
             */

            // Add code that mocks the "HelloWorld" method response

            Questions questions = new Questions(mock_answers.Object); // Inject the fake answers instance into Questions constructor

            // Act
            string expected_result = "Hello World";
            string actual_result = questions.SayHelloWorld();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOneMinusOneReturnsZero()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.Zero()).Returns(0);

            // Add code that mocks the "Zero" method response

            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 0;
            int actual_result = questions.OneMinusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);

            //We are working on false positives, trying to use the following:
            //mock_answers.Verify(a => a.Zero());
            //It isn't working just yet.
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.One()).Returns(1);

            // Add code that mocks the "Two" method response:
            // mock_answers.Setup(a => a.Two()).Returns(2);

            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 2;
            int actual_result = questions.OnePlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOnePlusTwoReturnsThree()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            // Add code that mocks the "Three" method response
            Questions questions = new Questions(mock_answers.Object);

            // Act
            int expected_result = 3;
            int actual_result = questions.OnePlusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureThisReturnsTrue()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            // Add code that mocks the "True" method response

            Questions questions = new Questions(mock_answers.Object);

            // Act
            bool expected_result = true;
            bool actual_result = questions.ReturnTrue();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureThisReturnsFalse()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            // Add code that mocks the "False" method response
            Questions questions = new Questions(mock_answers.Object);

            // Act
            bool expected_result = false;
            bool actual_result = questions.ReturnFalse();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureSayNothingReturnsEmptyString()
        {
            // Arrange
            Mock<Answers> mock_answers = new Mock<Answers>();
            
            // Add code that mocks the "EmptyString" method response
            Questions questions = new Questions(mock_answers.Object);

            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            Mock<Answers> mock_answers = new Mock<Answers>();
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 })
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            // Write this test
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            // Write this test
        }

    }
}
