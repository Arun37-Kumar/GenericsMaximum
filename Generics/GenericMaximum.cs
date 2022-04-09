using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;

        //Creating GenericMaximum Constructor (initializing value)
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }

        public T MaxValue(params T[] value)
        {
            var sorted_value = Sort(value);
            return sorted_value[value.Length - 1];
        }

        public T GenericMaxMethod()
        {
            var max = MaxValue(value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is : "+max);
        }

    }
    

    
}
