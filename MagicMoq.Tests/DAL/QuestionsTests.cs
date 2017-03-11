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
        private Mock<Answers> mock_answers { get; set; }
        //can also be called public, doesn't matter in this case
        private Questions questions { get; set; }

        [TestInitialize]
        public void SetupCommonItems() // name of this method does not matter
        {
            // Runs BEFORE every test
            mock_answers = new Mock<Answers>();

            questions = new Questions(mock_answers.Object);
        }

        // "Utility" Section 
        private void MyHelperMethod()
        {
            // Do some stuff, but it is not a test itself.
            // Can be called in any of these methods below.
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Runs AFTER every test
            mock_answers = null;
            questions = null;
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions a_question = new Questions();

            Assert.IsNotNull(a_question);
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
            //Questions questions = new Questions();
            //Don't need this anymore due to TestInitialize

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {

            // Hint 1: Create an instance of your Answers class
            Answers answer = new Answers();

            // Hint 2: Implement another Constructor (for Questions class)
            Questions questions = new Questions(/* Hint 3: inject an Answers instance here*/ answer);
            //We can get rid of this Questions item because of TestInitialize,
            //but I'm leaving it since it has notes

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureSayHelloReturnsHelloWorld()
        {
            // Arrange
            //Got rid of this now, due to TestInitialize
            //Mock<Answers> mock_answers = new Mock<Answers>(); // Creates a Mock
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World"); // How to hijack the method call
            /* 
             * a => a.something()
             * same as:
             * function(a) {
             *      return a.something();
             * }
             */

            // Add code that mocks the "HelloWorld" method response

            // Got ride of questions with TestInitialize:
            // Questions questions = new Questions(mock_answers.Object); // Inject the fake answers instance into Questions constructor

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
            mock_answers.Setup(a => a.Zero()).Returns(0);

            // Add code that mocks the "Zero" method response

            //Got rid of this due to TestInitialize:
            //Questions questions = new Questions(mock_answers.Object);

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
            mock_answers.Setup(a => a.One()).Returns(1);

            // Add code that mocks the "Two" method response:
            // mock_answers.Setup(a => a.Two()).Returns(2);


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
            mock_answers.Setup(a => a.Three()).Returns(3);
            

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
            mock_answers.Setup(a => a.True()).Returns(true);

            

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
            mock_answers.Setup(a => a.False()).Returns(false);

            

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
            mock_answers.Setup(a => a.EmptyString()).Returns("");
            
           

            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            //Arrange
            mock_answers.Setup(a => a.Two()).Returns(2);

            

            //Act
            int expected_result = 4;
            int actual_result = questions.TwoPlusTwo();

            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            //Arrange
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(b => b.Two()).Returns(2);
            mock_answers.Setup(c => c.One()).Returns(1);

            

            //Act
            int expected_result = 3;
            int actual_result = questions.FourMinusTwoPlusOne();

            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            //Arrange
            mock_answers.Setup(a => a.Four()).Returns(4);
            mock_answers.Setup(b => b.Two()).Returns(2);


            // Act
            int expected_result = 2;
            int actual_result = questions.FourMinusTwo();

            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            //Arrange

            //Less Restrictive: 
            //mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5 });

            //More Restrictive:
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 5))).Returns(new List<int> { 1, 2, 3, 4, 5 });


            //Act
            List<int> expected_result = new List<int> { 1,2,3,4,5 };
            List<int> actual_result = questions.CountToFive();

            //Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            //Arrange

            //"i" needs to be large enough so that the list contains 3 even numbers (you could have it go up to, say 100)
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 10))).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            //Act
            List<int> expected_result = new List<int> { 2, 4, 6 };
            List<int> actual_result = questions.FirstThreeEvenInts();

            //Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            //Arrange

            //"i" needs to be large enough so that the list contains 3 odd numbers (you could have it go up to, say 100)
            mock_answers.Setup(a => a.ListOfNInts(It.Is<int>(i => i == 10))).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            //Act
            List<int> expected_result = new List<int> { 1, 3, 5 };
            List<int> actual_result = questions.FirstThreeOddInts();

            //Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
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
