using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLive.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Get_Returns_A_Number()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Get_Returns_A_Number_For_4()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(4);

            Assert.That(result, Is.EqualTo("4"));
        }

        [Test]
        public void Get_Returns_Fizz_For_3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Get_Returns_Fizz_For_6()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Get_Returns_Buzz_For_5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Get_Returns_Buzz_For_10()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Get_Returns_FizzBuzz_For_15()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Get_Returns_FizzBuzz_For_30()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Get_Returns_Something_For_Negative3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.Get(-3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}
