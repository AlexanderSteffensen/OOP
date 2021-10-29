using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_1
{
    public class HandyMethods
    {
        public static T Max<T>(List<T> list) where T : IComparable<T>
        {
            T highest = list[0];
            foreach (var item in list)
            {
                if (highest.CompareTo(item) < 0)
                {
                    highest = item;
                }
            }
            return highest;
        }
        
        public static T Min<T>(List<T> list) where T : IComparable<T> {
            T lowest = list[0];
            foreach (var item in list)
            {
                if (lowest.CompareTo(item) > 0)
                {
                    lowest = item;
                }
            }
            return lowest;
        }
        
        public static T[] Copy<T>(T[] array1, T[] array2)
        {
            if (array1.Length != array2.Length)
                throw new Exception("The arrays are not the same length!");
                
            int index = 0;
            foreach (var item in array1)
            {
                 array2[index] = item;
                 index++;
            }
            return array2;
        }

        public static T[] Shuffle<T>(T[] array)
        {
            Random rnd = new Random();
            T temp;
            for (int n = 0; n < array.Length; n++)
            {
                int i = rnd.Next(0, array.Length);
                int j = rnd.Next(0, array.Length);
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }
        
        
    }
}