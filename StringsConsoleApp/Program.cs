using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringWorks;

namespace StringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new StringReduce();
            Console.WriteLine(obj.Go(Console.ReadLine()));
        }
    }
}
