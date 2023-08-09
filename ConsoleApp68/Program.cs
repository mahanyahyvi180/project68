using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ismale = true;
            bool istall = true;

            if (ismale && istall)
            {
                Console.WriteLine("you are tall male");
            }
            else if (ismale && !istall)
            {
                Console.WriteLine("you are short male");
            }
            else if (!ismale && istall)
            {
                Console.WriteLine("you are note a male but you are tall");
            }
            else
            {
                Console.WriteLine("you are either not male or not tall");
            }
            Console.ReadLine();
        }
    }
}
