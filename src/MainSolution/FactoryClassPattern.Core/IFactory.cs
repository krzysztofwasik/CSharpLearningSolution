﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassPattern.Core
{
    public interface IFactory
    {
        IComputer CreateComputer();
        ITablet CreateTablet();
        ISmartPhone CreateSmartPhone();
    }
}
