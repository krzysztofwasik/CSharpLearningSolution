using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassPattern.Core
{
    public class HandyDandyManufacturingCompany
    {
        private readonly IFactory factory;
        private readonly List<IComputer> computers;
        private readonly List<ITablet> tablets;
        private readonly List<ISmartPhone> phones;

        public IEnumerable<IComputer> Computers { get { return this.computers.ToArray(); } }
        public IEnumerable<ITablet> Tablets { get { return this.tablets.ToArray(); } }
        public IEnumerable<ISmartPhone> SmartPhones { get { return this.phones.ToArray(); } }
        
        public HandyDandyManufacturingCompany(IFactory factory)
        {
            this.factory = factory;
            this.computers = new List<IComputer>();
            this.tablets = new List<ITablet>();
            this.phones = new List<ISmartPhone>();
        }

        public void Produce(Order order)
        {
            CreateComputers(order.Computers);
            CreateTablets(order.Tablets);
            CreateSmartPhones(order.SmartPhones);
        }

        private void CreateComputers(int count)
        {
            while (this.computers.Count < count)
            {
                this.computers.Add(this.factory.CreateComputer());
            }
        }

        private void CreateTablets(int count)
        {
            while (this.tablets.Count < count)
            {
                this.tablets.Add(this.factory.CreateTablet());
            }
        }

        private void CreateSmartPhones(int count)
        {
            while (this.phones.Count < count)
            {
                this.phones.Add(this.factory.CreateSmartPhone());
            }
        }
    }
}
