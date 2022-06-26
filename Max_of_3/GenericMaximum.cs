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

        public T FirstValue, SecondValue, ThirdValue;
        public GenericMaximun(T FirstValue, T SecondValue, T ThirdValue)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }

        // Craeting Generic method to get Max Value 
        public static T MaxValue(T FirstValue, T SecondValue, T ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                return ThirdValue;
            }
            return default;
        }


        public T Max_Method()
        {
            T Max = GenericMaximun<T>.MaxValue(this.FirstValue, this.SecondValue, this.ThirdValue);
            Console.WriteLine("Max is: " + Max);
            return Max;
        }
    }
}
