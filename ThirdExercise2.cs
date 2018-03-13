using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1T3
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double res = mile * 1.60934;
            Console.WriteLine("{0:f2}", res);
        }
    }
}