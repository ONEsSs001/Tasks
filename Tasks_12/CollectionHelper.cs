using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_12
{
    internal static class CollectionHelper
    {
        public static void PrintReverse<T>(this IEnumerable<T> arr)
        {
            foreach (var item in arr.Reverse())
            {
                Console.WriteLine(item);
            }
        }


        public static T GetFirstElement<T>(this IEnumerable<T> arr)
        {
            foreach (var item in arr)
            {
                return item;
            }
            return default;
        }
        public static T GetLastElement<T>(this IEnumerable<T> arr)
        {
            T last = default;

            foreach (var item in arr)
            {
                last = item;
            }
            return last;
        }


        public static bool ContainsElement<T>(this IEnumerable<T> arr, T e)
        {
          
            foreach (var item in arr)
            {
                if (item.Equals(e))
                {
                    return true;
                }
            }
            return false;
            
        }

        public static int Count<T>(this IEnumerable<T> arr)
        {
           
            return arr.Count();
        }

        public static int Index<T>(this IEnumerable<T> arr, T e)
        {
            int i = 0;
            foreach (var item in arr)
            {
                if (item.Equals(e))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

     
    }
}
