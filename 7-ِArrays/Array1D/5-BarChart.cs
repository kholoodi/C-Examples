
using System;
    class IntArray
    {
        public static void Main(string[] args)
        {
            int [] array = {0, 0, 0, 0, 0, 0, 1, 2, 4, 1};
            Console.WriteLine("Grade disribution:");
           //For each element, output a bar of the chart 
            for(int counter = 0; counter < array.Length; counter++)
            {
                //output bar labels ("00-09",....,"90-99", "100:" )
                if (counter == 10)
                Console.WriteLine(" 100 :" ) ; 
                else
                Console.WriteLine("{0:D2}-{1:D2}:" ,counter *10,counter * 10 +9) ; 
                for(int stars = 0; stars < array[counter]; stars++)
                Console.WriteLine("*") ; 
                Console.WriteLine();
            }     
        }
    }



