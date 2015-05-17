using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    //public class GraphicsCard
    //{
    //    public decimal GpuFrequency { get; set; }
    //    public int AmountOfRam { get; set; }
    //}

    // Implementing deep cloning because of value types properties
     
      public class GraphicsCard : ICloneable
        {
            public decimal GpuFrequency { get; set; }
            public int AmountOfRam { get; set; }
            public object Clone()
            {
                return (GraphicsCard)MemberwiseClone();     
            }
        }
   
}
