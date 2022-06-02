using System;
using StuCalc;
using NUnit.Framework;
using Xunit;
using Moq;

namespace NunitTest
{
    public class Tests
    {
        [Fact]
        public void add_interface_test()
        {
            var interfaceObject = new Mock<CalcInterface>();
            interfaceObject.Setup(obj => obj.add(10, 20)).Returns(30);
            Xunit
            Xunit.Assert.Equal(30, interfaceObject.Object.add(10, 20));

        }
    }
}