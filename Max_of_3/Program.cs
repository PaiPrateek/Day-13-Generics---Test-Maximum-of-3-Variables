using System;

namespace Max_of_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find Max Number :");

            //Integer type data
            int[] intArray = { 85, 63, 98, 103 , 423, 325 };
            GenericMaximun<int> genericint = new GenericMaximun<int>(intArray);
            genericint.PrintMaxValue();

            //Double type data
            double[] doubleArray = { 22.63, 33.65, 75.62, 56.23, 421.23 };
            GenericMaximun<double> genericfloat = new GenericMaximun<double>(doubleArray);
            genericfloat.PrintMaxValue();

            //Double type data
            string[] strinArray = { "12", "56", "96", "85", "35"  };
            GenericMaximun<string> genericstring = new GenericMaximun<string>(strinArray);
            genericstring.PrintMaxValue();

            //Console.WriteLine("Find Max Number :");
            ////Integer type data
            //GenericMaximun<int> genericint = new GenericMaximun<int>(36, 53, 96);
            //genericint.Max_Method();

            ////Double type data
            //GenericMaximun<double> genericdouble = new GenericMaximun<double>(63.23, 56.75, 86.41);
            //genericdouble.Max_Method();

            ////String type data
            //GenericMaximun<string> genericstring = new GenericMaximun<string>("81", "96", "63");
            //genericstring.Max_Method();

            //Console.WriteLine("Find Max From the Given Integer");
            ////Test Case-1 :  Max at 1st Position
            //Console.WriteLine(Program.MaxIntegerNumber(65, 25, 55));

            ////Test Case-2 : Max at 2nd Position
            //Console.WriteLine(Program.MaxIntegerNumber(36, 85, 74));

            ////Test Case-3 : Max at 3rd Position
            //Console.WriteLine(Program.MaxIntegerNumber(78, 43, 92));

            //Console.WriteLine("............................................");
            //Console.WriteLine("Find Max From the Given Floats");

            ////Test Case-1 : Max at 1st Position
            //Console.WriteLine(Program.MaxFloatNumber(8.32f, 5.84f, 7.63f));

            ////Test Case-2 : Max at 2nd Position
            //Console.WriteLine(Program.MaxFloatNumber(4.51f, 7.98f, 6.84f));

            ////Test Case-3 : Max at 3rd Position
            //Console.WriteLine(Program.MaxFloatNumber(6.74f, 3.56f, 9.81f));

            //Console.WriteLine("............................................");
            //Console.WriteLine("Find Max From the Given Strings");

            ////Test Case-1 :Max at 1st Position
            //Console.WriteLine(Program.MaxStringNumber("69", "28", "45"));

            ////Test Case-2 :Max at 2nd Position
            //Console.WriteLine(Program.MaxStringNumber("62", "75", "49"));

            ////Test Case-3 :Max at 3rd Position
            //Console.WriteLine(Program.MaxStringNumber("21", "Banana", "35"));
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

        // Creating method to find the max from the given Strings
        public static string MaxStringNumber(string FirstValues, string SecondValue, string ThirdValue)
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
