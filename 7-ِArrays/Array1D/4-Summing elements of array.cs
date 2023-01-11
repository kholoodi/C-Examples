
using System;
    class IntArray
    {
        public static void Main(string[] args)
        {
            int [] array = {87,68, 94, 100, 83, 78, 85, 91, 76, 87};
            int total = 0;
           //Add each element's value to total
            for(int counter = 0; counter < array.Length; counter++)
            total += array[counter];
            Console.WriteLine("Totle of array elements :{0}" ,total) ;      
        }
    }



