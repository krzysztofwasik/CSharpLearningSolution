using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BuilderPattern.Core;


namespace BuilderPattern.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void BuilderTests_ExampleTest_ReturnsTrue()
        {
            Assert.True(1 == 1);
        }

        [Test]
        public void BuilderTests_IsStringBuilderObjectEqualToPredefinedString_ReturnsTrue()
        {
            string compareString = "hello world";

            var stringBuilderObject = new StringBuilder();

            stringBuilderObject.Append("hello");
            stringBuilderObject.Append(" ");
            stringBuilderObject.Append("world");

            Assert.True(stringBuilderObject.ToString() == compareString);
        }

        [Test]
        public void BuilderTests_IsEqualComputerObjectAndSuperComputerBuilderObjectWithTheSameSpecs_ReturnTrue()
        {
            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new SuperComputerBuilder();

            var superComputer = store.Build(builder);

            Assert.AreEqual(computer.AmountOfCores, superComputer.AmountOfCores);
            Assert.AreEqual(computer.AmountOfRam, superComputer.AmountOfRam);
            Assert.AreEqual(computer.CpuFrequency, superComputer.CpuFrequency);
            Assert.AreEqual(computer.DriveType, superComputer.DriveType);

        }

        [Test]
        public void BuilderTests_IsEqualComputerObjectAndNotSoSuperComputerBuilderObjectWithTheSameSpecs_ReturnTrue()
        {
            var computer = new Computer
            {
                AmountOfCores = 1,
                AmountOfRam = 2,
                CpuFrequency = 2.0m,
                DriveType = "hdd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new NotSoSuperComputerBuilder();

            var notSoSuperComputer = store.Build(builder);

            Assert.AreEqual(computer.AmountOfCores, notSoSuperComputer.AmountOfCores);
            Assert.AreEqual(computer.AmountOfRam, notSoSuperComputer.AmountOfRam);
            Assert.AreEqual(computer.CpuFrequency, notSoSuperComputer.CpuFrequency);
            Assert.AreEqual(computer.DriveType, notSoSuperComputer.DriveType);

        }
    }
}
