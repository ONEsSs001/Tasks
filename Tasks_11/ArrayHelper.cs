using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_11
{
    internal class ArrayHelper
    {
        public static void PrintReverse<T>(T[] arr)
        {
            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public static T GetFirstElement<T>(T[] arr)
        {
            return arr[0];
        }
        public static T GetLastElement<T>(T[] arr)
        {
           return arr[arr.Length - 1];
        }


        public static bool ContainsElement<T>(T[] arr, T e)
        {
            bool o = false;
            foreach (var item in arr)
            {
                if (item.Equals(e))
                {
                    o = true;
                }
            }
            return o;
        }

        public static int Count<T>(T[] arr) 
        {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
            }
            return count;
        }

        public static int Index<T>(T[] arr, T e)
        {
            int i = -1;

            for (int j = 0; j <= arr.Length - 1 ; j++)
            {
                if (arr[j].Equals(e))
                {
                    i = j;
                }
                
            }
            return i;
        }

        public static void Swap<T>(T[] arr, int index1, int index2)
        {
            T i = arr[index1];

            arr[index1] = arr[index2];
            arr[index2] = i;

        }
    }
}
