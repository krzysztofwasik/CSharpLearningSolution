using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Core
{
    public class NotSoSuperComputerBuilder : ComputerBuilder
    {
        public override void SetCores()
        {
            this.computer.AmountOfCores = 1;
        }

        public override void SetCpuFrequency()
        {
            this.computer.CpuFrequency = 2.0m;
        }

        public override void SetRam()
        {
            this.computer.AmountOfRam = 2;
        }

        public override void SetDriveType()
        {
            this.computer.DriveType = "hdd";
        }
    }
}
