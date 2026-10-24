using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Tasks_9
{
    internal class Array : IOutput2, ICalc2
    {


       public int[] array = [1, 5, 8, 3, 2, 6, 9];


        public int CountDistinct(int[] arr)
        {
           
            
            return arr.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare, int[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public void ShowEven(int[] arr)
        {
            foreach (var item in arr)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine("even " + item);
                }
            }
        }

        public void ShowOdd(int[] arr)
        {
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine("odd " + item);
                }
            }
        }
    }
}
