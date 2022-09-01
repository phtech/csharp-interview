using FizzBuzz;
using NUnit.Framework;

namespace CsharpInterviewTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        public void OutputTests(int number, string expected)
        {
            FizzBuzzer testSubject = new FizzBuzzer();
            var result = testSubject.Calculate(number);
            Assert.AreEqual(expected, result);
        }
       
    }
}
