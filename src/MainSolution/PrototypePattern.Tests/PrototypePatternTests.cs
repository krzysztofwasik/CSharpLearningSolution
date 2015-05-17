using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrototypePattern;

namespace PrototypePattern.Tests
{
    [TestFixture]
    public class PrototypePatternTests
    {
        [Test]
        public void PrototypePatternTests_IsTheSameComputerObjectWithCloneComputerObjectUsingMemberwiseClone_ReturnsTrue()
        {
            var gpu = new GraphicsCard
            {
                AmountOfRam = 4,
                GpuFrequency = 1.1m
            };
            var computer = new Computer
            {
                AmountOfCores = 4,
                AmountOfRam = 32,
                CpuFrequency = 3.4m,
                DriveType = "ssd",
                Gpu = gpu
            };

            // Clone of computer object using ICloneable Clone() method
            var computer2 = (Computer) computer.Clone(); // we have to cast because Clone() method return object of type object

            Assert.AreNotSame(computer,computer2);

            // Value type object can be equal but never are the same
            Assert.AreNotSame(computer.CpuFrequency,computer2.CpuFrequency);
            Assert.AreNotSame(computer.AmountOfRam, computer2.AmountOfRam);
            Assert.AreNotSame(computer.AmountOfCores, computer2.AmountOfCores);
           
            // because Clone method creates shallow copy, value type are copied bit by bit and
            // reference type is handled in way that it reference is copied to copy, but not referred object so both object refere to the same data
            Assert.AreSame(computer.DriveType, computer2.DriveType);
            
            // Assertion afte modification cloning with deep clone for Gpu
            Assert.AreNotSame(computer.Gpu,computer2.Gpu);

            // Because of shallow copy both object base and copier (shallow copy) will have the same value for Gpu.AmountOfRam
            //computer.Gpu.AmountOfRam = 8;
            Assert.AreEqual(computer.Gpu.AmountOfRam,computer2.Gpu.AmountOfRam);



        }
    }
}
