using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new HandyDandyApplication();
            app.DisplayUsers(Console.Out);


            Console.ReadKey();
        }
    }
}
