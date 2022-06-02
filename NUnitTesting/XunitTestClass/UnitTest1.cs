using System;
using Xunit;
using NuGet.Frameworks;
using StuCalc;


namespace XunitTestClass
{
    public class UnitTest1
    {
        Calc c = new Calc();
        [Fact]
        public void ClassAddTest()
        {
            var a = 11;
            var b = 39;
            var result = 50;
            Xunit.Assert.Equal(result, c.add(a, b));

        }
        [Fact]
        public void ClassMulTest()
        {
            var a = 8;
            var b = 7;
            var result = 56;
            Xunit.Assert.Equal(result, c.mul(a, b));

        }
        [Fact]
        public void ClassDivTest()
        {
            var a = 54;
            var b = 6;
            var result = 9;
            Xunit.Assert.Equal(result, c.div(a, b));

        }
        [Fact]
        public void ClassSubTest()
        {
            var a = 5;
            var b = 2;
            var result = 3;
            Xunit.Assert.Equal(result, c.sub(a, b));

        }
    }
}
