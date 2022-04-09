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
            int findMaxInt = MaximumNumberCheck.MaximumIntegerNumbers(23,43,12);
            Console.WriteLine("The maximum number among three is : "+findMaxInt);

            //Float Maximum Find
            float findMaxFloat = MaximumNumberCheck.MaximumFloatNumbers(12.12f,23.23f,43.23f);
            Console.WriteLine("Them maximum float number is : "+findMaxFloat);

            //String Maximum Find
            string findMaxString = MaximumNumberCheck.MaximumString("Apple","Peach","Banana");
            Console.WriteLine("The maximum string value is : "+findMaxString);

            int[] intArray = { 21, 23, 11, 43, 53, 89 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            float[] floatArray = { 23.4f, 23.5f, 78.1f, 90.34f };
            GenericMaximum<float> genericFloatMax = new GenericMaximum<float>(floatArray);
            genericFloatMax.PrintMaxValue();

            string[] stringArray = { "banana", "peach", "cherry", "apple", "kiwi" };
            GenericMaximum<string> genericStringMax = new GenericMaximum<string>(stringArray);
            genericStringMax.PrintMaxValue();

            Console.ReadLine();
        }
    }
}
