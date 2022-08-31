using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzTests
    {
        
        [TestCase(15, "Fizz Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        public void OutputTests(int number, string expected)
        {
            FizzBuzzer testSubject = new FizzBuzzer();
            var result = testSubject.Calculate(number);
            Assert.AreEqual(expected, result);
        }

        // What are the additional cases that should be added
        public void OtherTestCases(int number, string expected)
        {

        }
    }
}
