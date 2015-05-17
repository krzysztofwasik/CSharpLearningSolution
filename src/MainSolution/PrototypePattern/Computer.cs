using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The intension of prototype pattern is to create object based upon another object
 * - for implementation in C# we use ICloneable interface
 */ 

namespace PrototypePattern
{
    public class Computer : ICloneable
    {
        public int AmountOfCores { get; set; }
        public decimal CpuFrequency { get; set; }
        public int AmountOfRam { get; set; }
        public string DriveType { get; set; }
        public GraphicsCard Gpu { get; set; }

        public object Clone()
        {
            // This way we returning only shallow copy
            // return MemberwiseClone();

            // This is one way for deep cloning 
            //var clone = (Computer) MemberwiseClone();
            //clone.Gpu = new GraphicsCard
            //{
            //    AmountOfRam = Gpu.AmountOfRam,
            //    GpuFrequency = Gpu.GpuFrequency
            //};

            // The second way is to implement ICloneable to GraphicsCard class 
            // and fact that we have there value type be will be deep copying

            var clone = (Computer)MemberwiseClone();
            clone.Gpu = (GraphicsCard)Gpu.Clone();

            return clone;
        }
    }
}