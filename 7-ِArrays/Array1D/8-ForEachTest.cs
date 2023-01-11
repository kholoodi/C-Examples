
using System;
    class ForEachTest
    {
        public static void Main(string[] args)
        {
            int [] array = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            int total = 0;
            //Add each element's value to total
            foreach(int number in array)
            total += number;
            Console.WriteLine("Total of array elements : {0}", total );         
                 
        }
    }



