using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integer Maximum Find
            int findMax = MaximumNumberCheck.MaximumIntegerNumbers(23,43,12);
            Console.WriteLine("The maximum number among three is : "+findMax);
            Console.ReadLine();

        }
    }
}
