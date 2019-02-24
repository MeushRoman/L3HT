using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Dizel");
            Console.WriteLine(c.Info());
        }
    }
}
