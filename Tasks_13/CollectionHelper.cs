using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tasks_13
{
    internal static class CollectionHelper
    {

        public static List<T> CWhere<T>(this IEnumerable<T> col, Predicate<T> pred)
        {
            List<T> list = new List<T>();
            foreach (var item in col)
            {
                if(pred(item)) list.Add(item);

            }

            return list;
        }

        public static T FirstOrDef<T>(this IEnumerable<T> col, Predicate<T> pred)
        {
            foreach (var item in col)
            {
                if (pred(item))
                {
                    return item;
                }
            }
            return default;
        }

        public static bool CAny<T>(this IEnumerable<T> col, Predicate<T> pred)
        {
            foreach (var item in col)
            {
                if (pred(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CAll<T>(this IEnumerable<T> col, Predicate<T> pred)
        {
            foreach (var item in col)
            {
                if (!pred(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static int CCount<T>(this IEnumerable<T> col, Predicate<T> pred = null)
        {
            int count = 0;

            if (pred != null)
            {
                foreach (var item in col)
                {
                    if (pred(item)) count++;
                }
            }
            else
            {
                count = col.Count();
            }
          

            return count;
        }



    }
}
