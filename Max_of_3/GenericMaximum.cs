using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_of_3
{
    public class GenericMaximun<T> where T : IComparable
    {
        public T[] Value;

        public GenericMaximun(T[] value)
        {
            this.Value = value;
        }

        // Sorting the Array
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        // Return the Max Value from the Sorted array
        public T MaxValue(params T[] values)
        {
            var Sorted_Values = Sort(values);
            return Sorted_Values[^1];
        }

        //Calling the Max Value
        public T MaxMethod()
        {
            var Max = MaxValue(this.Value);
            return Max;
        }
        //Printing the Max value
        public void PrintMaxValue()
        {
            var Max = MaxValue(this.Value);
            Console.WriteLine("Max Value is: " + Max);
        }
    }
}
