using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class BuzzTests
    {
        [Test]
        public void NumberNotDivisibleByFiveIsUnchanged()
        {
            Assert.AreEqual(1, new Buzzer().Substitute(1));
        }

        [Test]
        public void NumberDivisibleByFiveIsBuzz()
        {
            Assert.AreEqual("Buzz", new Buzzer().Substitute(5));
        }

        [Test]
        public void ListOfFiveIsConverted()
        {
            List<object> input = new List<object>() {1, 2, 3, 4, 5};
            List<object> list = new Buzzer().Buzz(input);
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual("Buzz", list[4]);
        }
    }

    public class Buzzer
    {
        public object Substitute(int input)
        {
            if (input % 5 == 0)
                return "Buzz";
            return input;
        }

        public List<object> Buzz(List<object> input)
        {
            return input
                .Select(o => Substitute(input.IndexOf(o) + 1))
                .ToList();
        }
    }
}