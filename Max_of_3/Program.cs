using System;

namespace Max_of_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Case-1 :  Max at 1st Position
            Console.WriteLine(Program.MaxIntegerNumber(65, 25, 55));

            //Test Case-2 : Max at 2nd Position
            Console.WriteLine(Program.MaxIntegerNumber(36, 85, 74));

            //Test Case-3 : Max at 3rd Position
            Console.WriteLine(Program.MaxIntegerNumber(78, 43, 92));

            //Test Case-1 : Max at 1st Position
            Console.WriteLine(Program.MaxFloatNumber(8.32f, 5.84f, 7.63f));

            //Test Case-2 : Max at 2nd Position
            Console.WriteLine(Program.MaxFloatNumber(4.51f, 7.98f, 6.84f));

            //Test Case-3 : Max at 3rd Position
            Console.WriteLine(Program.MaxFloatNumber(6.74f, 3.56f, 9.81f));
        }
        // Creating method to find the max from the given integer
        public static int MaxIntegerNumber(int FirstValues, int SecondValue, int ThirdValue)
        {
            if (FirstValues.CompareTo(SecondValue) > 0 && FirstValues.CompareTo(ThirdValue) > 0 ||
               FirstValues.CompareTo(SecondValue) >= 0 && FirstValues.CompareTo(ThirdValue) > 0 ||
               FirstValues.CompareTo(SecondValue) > 0 && FirstValues.CompareTo(ThirdValue) >= 0)
            {
                return FirstValues;
            }
            if (SecondValue.CompareTo(FirstValues) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValues) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValues) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValues) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValues) >= 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValues) > 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                return ThirdValue;
            }
            return FirstValues;
        }

        // Creating method to find the max from the given Float
        public static float MaxFloatNumber(float FirstValues, float SecondValue, float ThirdValue)
        {
            if (FirstValues.CompareTo(SecondValue) > 0 && FirstValues.CompareTo(ThirdValue) > 0 ||
               FirstValues.CompareTo(SecondValue) >= 0 && FirstValues.CompareTo(ThirdValue) > 0 ||
               FirstValues.CompareTo(SecondValue) > 0 && FirstValues.CompareTo(ThirdValue) >= 0)
            {
                return FirstValues;
            }
            if (SecondValue.CompareTo(FirstValues) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValues) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValues) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValues) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValues) >= 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValues) > 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                return ThirdValue;
            }
            return FirstValues;
        }
    }
}
