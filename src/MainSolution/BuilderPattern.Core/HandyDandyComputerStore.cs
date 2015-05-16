using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Core
{
    public class HandyDandyComputerStore
    {
        public Computer Build(ComputerBuilder builder)
        {
            builder.SetCores();
            builder.SetCpuFrequency();
            builder.SetRam();
            builder.SetDriveType();

            return builder.GetComputer();
        }
    }
}
