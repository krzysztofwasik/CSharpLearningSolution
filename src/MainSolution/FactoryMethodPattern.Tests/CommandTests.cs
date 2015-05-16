using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FactoryMethodPattern.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void CommandTests_IsEqualVolmCmdWithDifferentParamFormat_ReturnsTrue()
        {
            var volume1 = new AquosCommand("VOLM", "30");
            var volume2 = AquosCommand.Volume(30);

            Assert.True(volume1.ToString() == volume2.ToString());
        }

        [Test]
        public void CommandTests_IsEqualPowrCmdWithDifferentParamFormat_ReturnTrue()
        {
            var power1 = new AquosCommand("POWR", "0");
            var power2 = AquosCommand.Power(PowerSetting.Off);

            Assert.True(power1.ToString() == power2.ToString());

           
        }
    }
}
