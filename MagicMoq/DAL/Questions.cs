using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IQuestions Interface
    // 2. Use the methods in your Answers class to address tasks/questions posed by this class
    // 3. Access an instance of your Answers class using the "Wand"
    public class Questions : IQuestions
    {
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions()
        {
            Wand = new Answers();
        }

        public Questions(Answers answers)
        {
            Wand = answers;
        }

        public List<int> CountToFive()
        {
            //throw new NotImplementedException();

            return Wand.ListOfNInts(5);
        }

        public List<int> FirstThreeEvenInts()
        {
            throw new NotImplementedException();
        }

        public List<int> FirstThreeOddInts()
        {
            throw new NotImplementedException();
        }

        public int FourMinusTwo()
        {
            //throw new NotImplementedException();

            return Wand.Four() - Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            //throw new NotImplementedException();

            return Wand.Four() - Wand.Two() + Wand.One();
        }

        public int FourPlusZero()
        {
            //throw new NotImplementedException();

            return Wand.Four() + Wand.Zero();
        }

        public int OneMinusOne()
        {
            //throw new NotImplementedException();

            //Option 1:
            return Wand.Zero();
            // This passes without Mocking becuase of False Positives (defaults to zero)

            //Option 2:
            //return Wand.One() - Wand.One();
        }

        public int OnePlusOne()
        {
            //throw new NotImplementedException();

            //Option 1:
            // return Wand.Two();

            //Option 2:
            return Wand.One() + Wand.One(); 
        }

        public int OnePlusTwo()
        {
            //throw new NotImplementedException();

            return Wand.One() + Wand.Two();
        }

        public bool ReturnFalse()
        {
            //throw new NotImplementedException();

            return Wand.False();
        }

        public bool ReturnTrue()
        {
            //throw new NotImplementedException();

            return Wand.True();
        }

        public string SayHelloWorld()
        {
            //throw new NotImplementedException();

            return Wand.HelloWorld();
        }

        public string SayNothing()
        {
            //throw new NotImplementedException();

            return Wand.EmptyString();
        }

        public int TwoMinusZero()
        {
            //throw new NotImplementedException();

            return Wand.Two() - Wand.Zero();
        }

        public int TwoPlusTwo()
        {
            //throw new NotImplementedException();

            return Wand.Two() + Wand.Two();
        }

        public int ZeroPlusZero()
        {
            throw new NotImplementedException();
        }
    }
}