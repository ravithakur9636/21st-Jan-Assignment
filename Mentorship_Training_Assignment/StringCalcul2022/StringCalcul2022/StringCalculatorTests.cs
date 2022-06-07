using System;
using Xunit;

namespace StringCalcul2022
{
    public class StringCalculatorTests
    {

        [Fact]
        public void return0_inEmptyString()
        {
            string result = StringCalculator.Add1("");
            Assert.Equal("0", result);
        }
        [Fact]
        public void given_string1_is_same_of_return_string1()
        {
            string result = StringCalculator.Add2("1");
            Assert.Equal("1", result);
        }
        [Fact]
        public void given_string2_is_same_of_return_string2()
        {
            string result = StringCalculator.Add("num");
            Assert.Equal("number", result);
        }
    }
}
