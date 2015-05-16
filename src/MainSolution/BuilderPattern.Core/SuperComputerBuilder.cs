using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Core
{
    public class SuperComputerBuilder : ComputerBuilder
    {
        public override void SetCores()
        {
            this.computer.AmountOfCores = 64;
        }

        public override void SetCpuFrequency()
        {
            this.computer.CpuFrequency = 3.4m;
        }

        public override void SetRam()
        {
            this.computer.AmountOfRam = 256;
        }

        public override void SetDriveType()
        {
            this.computer.DriveType = "ssd";
        }
        
    }
}
