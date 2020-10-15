using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett heltal: ");
            int theInt = int.Parse(Console.ReadLine());
            while(true)
            if(theInt > 0)
            {
                Console.WriteLine("Talet är större än noll");
            }
            else if(theInt == 0)
            {
                Console.WriteLine("Talet är like med noll");
            }
            else
            {
                Console.WriteLine("Talet är mindre än noll");
            }

            Console.ReadKey();
        }
    }
}
