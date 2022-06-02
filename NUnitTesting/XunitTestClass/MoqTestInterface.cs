using System;
using System.Collections.Generic;
using System.Text;
using StuCalc;
using Xunit;
using NuGet.Frameworks;
using Moq;


namespace XunitTestClass
{
   public class MoqTestInterface
    {
        [Fact]
        public void addInterfaceTest()
        {
            var interfaceObj = new Mock<CalcInterface>();
            interfaceObj.Setup(obj => obj.add(10, 20)).Returns(30);
            Xunit.Assert.Equal(30, interfaceObj.Object.add(10, 20));

        } [Fact]
        public void mulInterfaceTest()
        {
            var interfaceObj = new Mock<CalcInterface>();
            interfaceObj.Setup(obj => obj.mul(6, 7)).Returns(42);
            Xunit.Assert.Equal(42, interfaceObj.Object.mul(6, 7));

        } [Fact]
        public void divInterfaceTest()
        {
            var interfaceObj = new Mock<CalcInterface>();
            interfaceObj.Setup(obj => obj.div(15, 3)).Returns(5);
            Xunit.Assert.Equal(5, interfaceObj.Object.div(15, 3));

        } [Fact]
        public void subInterfaceTest()
        {
            var interfaceObj = new Mock<CalcInterface>();
            interfaceObj.Setup(obj => obj.sub(8, 4)).Returns(4);
            Xunit.Assert.Equal(4, interfaceObj.Object.sub(8, 4));

        }
    }
}
