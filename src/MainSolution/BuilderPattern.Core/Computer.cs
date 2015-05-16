using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Core
{
    public class Computer
    {
        public decimal CpuFrequency { get; set; }
        public int AmountOfCores { get; set; }
        public string DriveType { get; set; }
        public int AmountOfRam { get; set; }
    }
}
