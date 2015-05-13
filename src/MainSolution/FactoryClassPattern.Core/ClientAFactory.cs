using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassPattern.Core
{
    public class ClientAFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientAComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientATablet();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientASmartPhone();
        }
    }
}
