using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ExtendingExistingInterfaceForService
{
    /// <summary>
    /// Interface doing something in legacy code  
    /// </summary>
    public interface IMyCode
    {
        void GetResult();
    }

    /// <summary>
    ///  New interface which inherit from IMyCode so this interface can by expose by servie for exampel
    /// </summary>
    [ServiceContract]
    public interface IMyCodeService : IMyCode
    {
        [OperationContract]
        void GetResult();
    }
    
      public class MyCodeService : IMyCodeService
    {
        public void GetResult()
        {
            Console.WriteLine("Result from IMyCodeService");
        }
    }
      
    class Program
    {
        static void Main(string[] args)
        {
            MyCodeService service = new MyCodeService();
            IMyCodeService serviceContract = (IMyCodeService)service;
            IMyCode codeContract = (IMyCode)service;

            service.GetResult();
            serviceContract.GetResult();
            codeContract.GetResult();


            // Prevents from shutdown console window
            Console.ReadKey();
        }
    }
}
