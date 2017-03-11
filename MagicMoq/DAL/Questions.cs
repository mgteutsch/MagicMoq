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
            //throw new NotImplementedException();

            //need at least up to 6:
            List<int> numbers = Wand.ListOfNInts(10); //not sorted, though
            //use numbers.Sort() if ListOfNInts doesn't return in order
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }

                if (result.Count == 3)
                {
                    break; //exit loop
                }
            }
            return result;
            //You can instead use Sort as result.Sort();
        }

        public List<int> FirstThreeOddInts()
        {
            //Also, in order to restrict the number of numbers getting pulled in,
            //We can create a counter that then has a limit within the foreach statement
            //take a look at the second if statement below
            
            //need at least up to 5 (we have refactored for 10 to limit):
            List<int> numbers = Wand.ListOfNInts(10);
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }

                if (result.Count == 3)
                {
                    break; //exit loop
                }
            }
            return result;
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

            return Wand.Three();
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
            //in class example: !Wand.False();
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
            return Wand.Zero();
        }
    }
}