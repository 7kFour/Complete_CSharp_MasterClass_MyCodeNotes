using System;

namespace Params_MinValue {
    internal class Program {
        static void Main(string[] args) {

            int min = MinV2(634, 83, 21, 9, 124523, 7, 53, 126, 10023, 33, -34);
            Console.WriteLine($"min value of arguments is: {min}");

        }

        public static int  MinV2 (params int[] nums) {

            // this variable is now set to the highest possible value an int type can hold
            // so its like 2bn and some change
            // we will use it to see if the ints we pass as arguments are
            // lower than the max value an int can hold
            int min = int.MaxValue;

            foreach (int num in nums) {
                if (num < min) {
                    min = num;
                }
            }
            return min;
        }
    }
}
